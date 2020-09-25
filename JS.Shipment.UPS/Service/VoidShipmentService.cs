using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using JS.Shipment.UPS.Contract.Service;
using System;
using System.Threading.Tasks;
using JS.Shipment.UPS.Model;
using Microsoft.Extensions.Options;
using JS.Shipment.UPS.Configuration;
using System.Linq;

namespace JS.Shipment.UPS.Service
{
    public class VoidShipmentService : BaseService, IVoidShipmentService
    {
        public VoidShipmentService(IOptions<UPSConfiguration> config) : base(config)
        {
        }
        public async Task<INativeVoidShipmentResponse> ProcessVoidAsync(IVoidShipmentRequest request, IUPSConfiguration configuration = null)
        {
            Void.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Void.UPSSecurity>(configuration?.Authentication) : UPSVoidAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };
            var voidRequest = BuildRequest<VoidShipmentRequest, Void.VoidShipmentRequest>((VoidShipmentRequest)request, VoidMapperConfiguration);

            //var client = new Void.VoidPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.VoidServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.VoidServiceUrl;
            var client = new Void.VoidPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);
            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(voidRequest);
            var response = await client.ProcessVoidAsync(upsSecurity, voidRequest);
            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            var nativeResponse = BuildResponse<Void.VoidShipmentResponse1, NativeVoidShipmentResponse>(response, VoidMapperConfiguration);
            if (request?.VoidShipment?.TrackingNumber?.Count() > 0)
            {
                if (nativeResponse.IsSuccessful)
                {
                    if (nativeResponse?.DeletedPackageTrackingNumberList?.Count > 0)
                        nativeResponse.Message = string.Format(MessageConfiguration.SuccessfulPackageDeletion, request?.VoidShipment?.ShipmentIdentificationNumber, nativeResponse?.DeletedPackageTrackingNumbers);
                    if (nativeResponse?.AlreadyDeletedPackageTrackingNumberList?.Count > 0)
                        nativeResponse.Message += string.Format(MessageConfiguration.AlreadyDeletedPackage, request?.VoidShipment?.ShipmentIdentificationNumber, nativeResponse?.AlreadyDeletedPackageTrackingNumbers);
                    if (nativeResponse?.FailedDeletionPackageTrackingNumberList?.Count > 0)
                        nativeResponse.Message += string.Format(MessageConfiguration.FailedPackageDeletion, request?.VoidShipment?.ShipmentIdentificationNumber, nativeResponse?.FailedDeletionPackageTrackingNumbers);
                }
                else
                    nativeResponse.Message = string.Format(MessageConfiguration.FailedPackageDeletion, request?.VoidShipment?.ShipmentIdentificationNumber, request?.VoidShipment?.TrackingNumber);
            }
            else
            {
                nativeResponse.Message = nativeResponse.IsSuccessful && nativeResponse.IsDeleted ?
                    string.Format(MessageConfiguration.SuccessfulShipmentDeletion, request?.VoidShipment?.ShipmentIdentificationNumber)
                    : string.Format(MessageConfiguration.FailedShipmentDeletion, request?.VoidShipment?.ShipmentIdentificationNumber);
            }
            return nativeResponse;
        }
    }
}
