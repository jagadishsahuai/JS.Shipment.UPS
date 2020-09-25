using Microsoft.Extensions.Options;
using JS.Shipment.UPS.Configuration;
using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using JS.Shipment.UPS.Contract.Service;
using System.Threading.Tasks;
using JS.Shipment.UPS.Model;
using System.Collections.Generic;

namespace JS.Shipment.UPS.Service
{
    public class PickupService : BaseService, IPickupService
    {
        public PickupService(IOptions<UPSConfiguration> config) : base(config)
        {
        }
        public async Task<INativePickupCreationResponse> ProcessPickupCreationAsync(IPickupCreationRequest request, IUPSConfiguration configuration = null)
        {
            Pickup.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Pickup.UPSSecurity>(configuration?.Authentication) : UPSPickupAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "Pickup" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };

            var pickupRequest = BuildRequest<PickupCreationRequest, Pickup.PickupCreationRequest>((PickupCreationRequest)request, PickupMapperConfiguration);
            //var client = new Pickup.PickupPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.PickupServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.PickupServiceUrl;
            var client = new Pickup.PickupPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);

            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(pickupRequest);
            //var xsdFiles = new Dictionary<string, string>();
            //xsdFiles.Add(@"E:\POC\UPS\Pickup\PickupforPACKAGEWebService\SCHEMAS-WSDLs\PickupWebServiceSchema.xsd", "http://www.ups.com/XMLSchema/XOLTWS/Pickup/v1.1");
            //xsdFiles.Add(@"E:\POC\UPS\Pickup\PickupforPACKAGEWebService\SCHEMAS-WSDLs\common.xsd", "http://www.ups.com/XMLSchema/XOLTWS/Common/v1.0");
            //xsdFiles.Add(@"E:\POC\UPS\Pickup\PickupforPACKAGEWebService\SCHEMAS-WSDLs\Error1.1.xsd", "http://www.ups.com/XMLSchema/XOLTWS/Error/v1.1");
            //xsdFiles.Add(@"E:\POC\UPS\Pickup\PickupforPACKAGEWebService\SCHEMAS-WSDLs\UPSSecurity.xsd", "http://www.ups.com/XMLSchema/XOLTWS/UPSS/v1.0");
            //var isValid = Validate(pickupRequest, xsdFiles, out string errorMessage);
            //if (!isValid)
            //    throw new System.Exception(errorMessage);
            var response = await client.ProcessPickupCreationAsync(upsSecurity, pickupRequest);

            if (Configuration.AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);

            var nativeResponse = BuildResponse<Pickup.PickupCreationResponse1, NativePickupCreationResponse>(response, PickupMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulPickupCreation, nativeResponse?.PickupConfirmationNumber)
                : string.Format(MessageConfiguration.FailedPickupCreation);
            return nativeResponse;
        }
        public async Task<INativePickupCancelResponse> ProcessPickupCancelAsync(IPickupCancelRequest request, IUPSConfiguration configuration = null)
        {
            Pickup.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Pickup.UPSSecurity>(configuration?.Authentication) : UPSPickupAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };

            var pickupRequest = BuildRequest<PickupCancelRequest, Pickup.PickupCancelRequest>((PickupCancelRequest)request, PickupMapperConfiguration);
            //var client = new Pickup.PickupPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.PickupServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.PickupServiceUrl;
            var client = new Pickup.PickupPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);

            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(pickupRequest);

            var response = await client.ProcessPickupCancelAsync(upsSecurity, pickupRequest);

            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);

            var nativeResponse = BuildResponse<Pickup.PickupCancelResponse1, NativePickupCancelResponse>(response, PickupMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulPickupCancelation, request?.PRN)
                : string.Format(MessageConfiguration.FailedPickupCancelation);
            return nativeResponse;
        }
        public async Task<INativePickupGetServiceCenterFacilitiesResponse> ProcessPickupGetServiceCenterFacilitiesAsync(IPickupGetServiceCenterFacilitiesRequest request, IUPSConfiguration configuration = null)
        {
            Pickup.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Pickup.UPSSecurity>(configuration?.Authentication) : UPSPickupAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };

            var pickupRequest = BuildRequest<PickupGetServiceCenterFacilitiesRequest, Pickup.PickupGetServiceCenterFacilitiesRequest>((PickupGetServiceCenterFacilitiesRequest)request, PickupMapperConfiguration);
            //var client = new Pickup.PickupPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.PickupServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.PickupServiceUrl;
            var client = new Pickup.PickupPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);

            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(pickupRequest);

            var response = await client.ProcessPickupGetServiceCenterFacilitiesAsync(upsSecurity, pickupRequest);

            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);

            var nativeResponse = BuildResponse<Pickup.PickupGetServiceCenterFacilitiesResponse1, NativePickupGetServiceCenterFacilitiesResponse>(response, PickupMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                MessageConfiguration.SuccessfulGetServiceCenterFacilities
                : MessageConfiguration.FailedGetServiceCenterFacilities;
            return nativeResponse;
        }
        public async Task<INativePickupPendingStatusResponse> ProcessPickupPendingStatusAsync(IPickupPendingStatusRequest request, IUPSConfiguration configuration = null)
        {
            Pickup.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Pickup.UPSSecurity>(configuration?.Authentication) : UPSPickupAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };

            var pickupRequest = BuildRequest<PickupPendingStatusRequest, Pickup.PickupPendingStatusRequest>((PickupPendingStatusRequest)request, PickupMapperConfiguration);
            //var client = new Pickup.PickupPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.PickupServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.PickupServiceUrl;
            var client = new Pickup.PickupPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);

            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(pickupRequest);

            var response = await client.ProcessPickupPendingStatusAsync(upsSecurity, pickupRequest);

            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);

            var nativeResponse = BuildResponse<Pickup.PickupPendingStatusResponse1, NativePickupPendingStatusResponse>(response, PickupMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                MessageConfiguration.SuccessfulPickupPendingStatusFetched
                : MessageConfiguration.FailedPickupPendingStatusFetched;
            return nativeResponse;
        }
        public async Task<INativePickupRateResponse> ProcessPickupRateAsync(IPickupRateRequest request, IUPSConfiguration configuration = null)
        {
            Pickup.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Pickup.UPSSecurity>(configuration?.Authentication) : UPSPickupAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };

            var pickupRequest = BuildRequest<PickupRateRequest, Pickup.PickupRateRequest>((PickupRateRequest)request, PickupMapperConfiguration);
            //var client = new Pickup.PickupPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.PickupServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.PickupServiceUrl;
            var client = new Pickup.PickupPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);

            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(pickupRequest);

            var response = await client.ProcessPickupRateAsync(upsSecurity, pickupRequest);

            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            var nativeResponse = BuildResponse<Pickup.PickupRateResponse1, NativePickupRateResponse>(response, PickupMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                MessageConfiguration.SuccessfulPickupRateFetched
                : MessageConfiguration.FailedPickupRateFetched;
            return nativeResponse;
        }
        public async Task<INativePickupGetPoliticalDivision1ListResponse> ProcessPickupGetPoliticalDivision1ListAsync(IPickupGetPoliticalDivision1ListRequest request, IUPSConfiguration configuration = null)
        {
            Pickup.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Pickup.UPSSecurity>(configuration?.Authentication) : UPSPickupAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };

            var pickupRequest = BuildRequest<PickupGetPoliticalDivision1ListRequest, Pickup.PickupGetPoliticalDivision1ListRequest>((PickupGetPoliticalDivision1ListRequest)request, PickupMapperConfiguration);
            //var client = new Pickup.PickupPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.PickupServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.PickupServiceUrl;
            var client = new Pickup.PickupPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);
            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(pickupRequest);
            var response = await client.ProcessPickupGetPoliticalDivision1ListAsync(upsSecurity, pickupRequest);
            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            var nativeResponse = BuildResponse<Pickup.PickupGetPoliticalDivision1ListResponse1, NativePickupGetPoliticalDivision1ListResponse>(response, PickupMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                MessageConfiguration.SuccessfulPickupGetPoliticalDivision1ListFetched
                : MessageConfiguration.FailedPickupGetPoliticalDivision1ListFetched;
            return nativeResponse;
        }
    }
}
