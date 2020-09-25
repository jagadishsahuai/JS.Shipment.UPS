using Microsoft.Extensions.Options;
using JS.Shipment.UPS.Configuration;
using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using JS.Shipment.UPS.Contract.Service;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using JS.Shipment.UPS.Model;
using System.IO;

namespace JS.Shipment.UPS.Service
{
    public class LabelRecoveryService : BaseService, ILabelRecoveryService
    {
        public LabelRecoveryService(IOptions<UPSConfiguration> configuration) : base(configuration)
        {

        }
        public async Task<INativeLabelRecoveryResponse> ProcessLabelRecoveryAsync(ILabelRecoveryRequest request, IUPSConfiguration configuration = null)
        {
            UpsLabelRecovery.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<UpsLabelRecovery.UPSSecurity>(configuration?.Authentication) : UPSLabelRecoveryAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };

            var upsRequest = BuildRequest<LabelRecoveryRequest, UpsLabelRecovery.LabelRecoveryRequest>((LabelRecoveryRequest)request, LabelRecoveryMapperConfiguration);
            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(upsRequest);
            //var client = new UpsLabelRecovery.PortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.LabelRecoveryServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.LabelRecoveryServiceUrl;
            var client = new UpsLabelRecovery.PortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);
            var response = await client.ProcessLabelRecoveryAsync(upsSecurity, upsRequest);

            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            var nativeResponse = BuildResponse<UpsLabelRecovery.LabelRecoveryResponse1, NativeLabelRecoveryResponse>(response, LabelRecoveryMapperConfiguration);

            if (nativeResponse.IsSuccessful && LabelConfiguration.SaveLabelFile && AppSetupConfiguration.SaveLabelFileAfterLabelRecoverySuccess)
            {
                SaveLabels(response?.LabelRecoveryResponse?.Items, out List<string> labelFiles);
                nativeResponse.LabelFiles = labelFiles;
            }
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulLabelRecovery, request?.TrackingNumber)
                : string.Format(MessageConfiguration.FailedLabelRecovery, request?.TrackingNumber);
            return nativeResponse;
        }
        private bool SaveLabels(object[] items, out List<string> labelFiles)
        {
            bool isSaved = false;
            labelFiles = new List<string>();
            foreach (var item in items)
            {
                var packageResult = (UpsLabelRecovery.LabelResultsType)item;
                if (packageResult != null)
                {
                    if (!Directory.Exists(LabelConfiguration.LabelRecoveryDirectory))
                        Directory.CreateDirectory(LabelConfiguration.LabelRecoveryDirectory);

                    //var labelFile = $"{LabelConfiguration.Directory}\\ {LabelConfiguration.FileNamePrefixDefinedInHtmlFile}{packageResult.TrackingNumber}{LabelConfiguration.FileExtention}";
                    string filenamePrefix = packageResult?.LabelImage?.LabelImageFormat == null ? LabelConfiguration.FileNamePrefixDefinedInHtmlFile : string.Empty;
                    var labelFile = $"{LabelConfiguration.LabelRecoveryDirectory}\\{filenamePrefix}{packageResult.TrackingNumber}.{packageResult?.LabelImage?.LabelImageFormat?.Code ?? "GIF"}";
                    using (FileStream fileStream = new FileStream(labelFile, FileMode.Create))
                    {
                        //***Save Base64 Encoded string as Image File***//

                        //Convert Base64 Encoded string to Byte Array.
                        var labelBuffer = Convert.FromBase64String(packageResult?.LabelImage?.GraphicImage);
                        fileStream.Write(labelBuffer, 0, labelBuffer.Length);
                        fileStream.Close();
                        labelFiles.Add(labelFile);
                    }
                    if (packageResult?.LabelImage?.PDF417 != null)
                    {
                        var pdf417File = $"{LabelConfiguration.LabelRecoveryDirectory}\\{filenamePrefix}{packageResult.TrackingNumber}pdf417{packageResult?.LabelImage?.LabelImageFormat?.Code ?? ".GIF"}";
                        var pdf417Buffer = Convert.FromBase64String(packageResult?.LabelImage?.PDF417);
                        using (FileStream pdf417fileStream = new FileStream(pdf417File, FileMode.Create))
                        {
                            pdf417fileStream.Write(pdf417Buffer, 0, pdf417Buffer.Length);
                            pdf417fileStream.Close();
                        }
                    }
                    if (LabelConfiguration.SaveLabelHtmlFile)
                    {
                        if (packageResult?.LabelImage?.HTMLImage != null)
                        {
                            var htmlFile = $"{LabelConfiguration.LabelRecoveryDirectory}\\{packageResult.TrackingNumber}.html";
                            File.WriteAllText(htmlFile, Base64Decode(packageResult?.LabelImage?.HTMLImage));
                        }
                    }
                    
                }
            }
            return isSaved;
        }
    }
}
