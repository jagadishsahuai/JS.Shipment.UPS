using Microsoft.Extensions.Options;
using JS.Shipment.UPS.Configuration;
using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using JS.Shipment.UPS.Contract.Service;
using JS.Shipment.UPS.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace JS.Shipment.UPS.Service
{
    public class ShipmentService : BaseService, IShipmentService
    {
        public ShipmentService(IOptions<UPSConfiguration> configuration) : base(configuration) { }
        public async Task<INativeShipmentResponse> ProcessShipmentAsync(IShipmentRequest request, IUPSConfiguration configuration = null)
        {
            Ship.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Ship.UPSSecurity>(configuration?.Authentication) : UPSShipmentAuthenticationDetail;
            SetupConfiguration(request, configuration);
            var shipmentRequest = BuildRequest<ShipmentRequest, Ship.ShipmentRequest>((ShipmentRequest)request, ShipmentMapperConfiguration);

            //var client = new Ship.ShipPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.ShipServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.ShipServiceUrl;
            var client = new Ship.ShipPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);
            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(shipmentRequest);
            var response = await client.ProcessShipmentAsync(upsSecurity, shipmentRequest);
            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            var nativeResponse = BuildResponse<Ship.ShipmentResponse1, NativeShipmentResponse>(response, ShipmentMapperConfiguration);
            if (nativeResponse.IsSuccessful && LabelConfiguration.SaveLabelFile && AppSetupConfiguration.SaveLabelFileAfterCreateSuccess)
                SaveLabels(nativeResponse.ShipmentResponse?.ShipmentResults, out List<string> labelFiles);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulShipmentCreation, nativeResponse.MasterTrackingReferenceNumber, nativeResponse.PackageTrackingReferenceNumbers)
                : string.Format(MessageConfiguration.FailedShipmentCreation);
            return nativeResponse;
        }
        private bool SaveLabels(IShipmentResultsType results, out List<string> labelFiles)
        {
            bool isSaved = false;
            labelFiles = new List<string>();
            foreach (var packageResult in results?.PackageResults)
            {
                if (packageResult?.ShippingLabel != null)
                {
                    if (!Directory.Exists(LabelConfiguration.Directory))
                        Directory.CreateDirectory(LabelConfiguration.Directory);

                    var labelFile = $"{LabelConfiguration.Directory}\\{LabelConfiguration.FileNamePrefixDefinedInHtmlFile}{packageResult.TrackingNumber}{LabelConfiguration.FileExtention}";
                    FileStream fileStream = new FileStream(labelFile, FileMode.Create);
                    //***Save Base64 Encoded string as Image File***//
                    //Convert Base64 Encoded string to Byte Array.
                    var labelBuffer = Convert.FromBase64String(packageResult?.ShippingLabel?.GraphicImage);
                    fileStream.Write(labelBuffer, 0, labelBuffer.Length);
                    if (LabelConfiguration.SaveLabelHtmlFile)
                    {
                        var htmlFile = $"{LabelConfiguration.Directory}\\{packageResult.TrackingNumber}.html";
                        File.WriteAllText(htmlFile, Base64Decode(packageResult?.ShippingLabel?.HTMLImage));
                    }
                    fileStream.Close();
                    labelFiles.Add(labelFile);
                }
            }
            return isSaved;
        }
        public async Task<INativeShipConfirmResponse> ProcessShipConfirmAsync(IShipConfirmRequest request, IUPSConfiguration configuration = null)
        {
            Ship.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Ship.UPSSecurity>(configuration?.Authentication) : UPSShipmentAuthenticationDetail;
            SetupConfiguration(request, configuration);
            var shipmentRequest = BuildRequest<ShipConfirmRequest, Ship.ShipConfirmRequest>((ShipConfirmRequest)request, ShipmentMapperConfiguration);
            //var client = new Ship.ShipPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.ShipServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.ShipServiceUrl;
            var client = new Ship.ShipPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);
            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(shipmentRequest);
            var response = await client.ProcessShipConfirmAsync(upsSecurity, shipmentRequest);
            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response.ShipConfirmResponse);
            var nativeResponse = BuildResponse<Ship.ShipConfirmResponse1, NativeShipConfirmResponse>(response, ShipmentMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulShipConfirmCreation, nativeResponse.MasterTrackingReferenceNumber)
                : string.Format(MessageConfiguration.FailedShipConfirmCreation);
            return nativeResponse;
        }
        public async Task<INativeShipAcceptResponse> ProcessShipAcceptAsync(IShipAcceptRequest request, IUPSConfiguration configuration = null)
        {
            Ship.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Ship.UPSSecurity>(configuration?.Authentication) : UPSShipmentAuthenticationDetail;

            //var client = new Ship.ShipPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.ShipServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.ShipServiceUrl;
            var client = new Ship.ShipPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);
            var shipmentRequest = BuildRequest<ShipAcceptRequest, Ship.ShipAcceptRequest>((ShipAcceptRequest)request, ShipmentMapperConfiguration);
            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(shipmentRequest);
            var response = await client.ProcessShipAcceptAsync(upsSecurity, shipmentRequest);
            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            var nativeResponse = BuildResponse<Ship.ShipAcceptResponse1, NativeShipAcceptResponse>(response, ShipmentMapperConfiguration);
            if (nativeResponse.IsSuccessful && LabelConfiguration.SaveLabelFile && AppSetupConfiguration.SaveLabelFileAfterAcceptSuccess)
                SaveLabels(nativeResponse.ShipAcceptResponse?.ShipmentResults, out List<string> labelFiles);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulShipAcceptCreation, nativeResponse.MasterTrackingReferenceNumber, nativeResponse.PackageTrackingReferenceNumbers)
                : string.Format(MessageConfiguration.FailedShipAcceptCreation);
            return nativeResponse;
        }
    }
}
