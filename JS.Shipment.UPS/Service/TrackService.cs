using Microsoft.Extensions.Options;
using JS.Shipment.UPS.Configuration;
using System;
using System.Threading.Tasks;
using JS.Shipment.UPS.Model;
using JS.Shipment.UPS.Contract.Data;
using JS.Shipment.UPS.Contract.Service;
using JS.Shipment.UPS.Contract.Criteria;
using JS.Shipment.UPS.Contract.Configuration;

namespace JS.Shipment.UPS.Service
{
    public class TrackService : BaseService, ITrackService
    {
        public TrackService(IOptions<UPSConfiguration> configuration) : base(configuration)
        {

        }
        public async Task<INativeTrackResponse> ProcessTrackAsync(ITrackRequest request, IUPSConfiguration configuration = null)
        {
            Track.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Track.UPSSecurity>(configuration?.Authentication) : UPSTrackAuthenticationDetail;
            request.Request = request?.Request ?? new RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } };
            request.TrackingOption = request?.TrackingOption ?? configuration?.TrackConfiguration?.TrackingOption ?? Configuration?.TrackConfiguration?.TrackingOption;
            //var trackRequest = BuildTrackRequest(request);
            var trackRequest = BuildRequest<TrackRequest, Track.TrackRequest>((TrackRequest)request, TrackShipmentMapperConfiguration);
            if (AppSetupConfiguration.WriteXmlRequest)
                WriteXML(trackRequest);
            //var client = new Track.TrackPortTypeClient();
            string endPointUrl = AppSetupConfiguration.IsProductionEnvironment ? AppSetupConfiguration?.Urls?.ProductionEndPoint?.TrackServiceUrl : AppSetupConfiguration?.Urls?.TestEndPoint?.TrackServiceUrl;
            var client = new Track.TrackPortTypeClient(endPointUrl, AppSetupConfiguration.TimeOut, AppSetupConfiguration?.UserId, AppSetupConfiguration?.Password);
            var response = await client.ProcessTrackAsync(upsSecurity, trackRequest);
            if (AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            //var nativeResponse = BuildNativeTrackResponse(response);
            var nativeResponse = BuildResponse<Track.TrackResponse1, NativeTrackResponse>(response, TrackShipmentMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulShipmentTracking, request?.InquiryNumber)
                : string.Format(MessageConfiguration.FailedShipmentTracking, request?.InquiryNumber);
            return nativeResponse;
        }
        public async Task<INativeTrackResponse> ProcessTrackAsync(ITrackCriteria criteria, IUPSConfiguration configuration = null)
        {
            Track.UPSSecurity upsSecurity = configuration != null ? SetupAuthentication<Track.UPSSecurity>(configuration?.Authentication) : UPSTrackAuthenticationDetail;
            var trackRequest = new Track.TrackRequest
            {
                InquiryNumber = criteria.TrackingReferenceNumber,
                PickupDateRange = new Track.PickupDateRangeType
                {
                    BeginDate = criteria?.PickupDateRange?.BeginDate,
                    EndDate = criteria?.PickupDateRange?.EndDate
                },
                ReferenceNumber = new Track.ReferenceNumberType
                {
                    Code = criteria?.ReferenceNumber?.Code,
                    Value = criteria?.ReferenceNumber?.Value
                },
                ShipperNumber = criteria?.ShipperNumber,
                Request = criteria?.RequestType != null ?
                new Track.RequestType
                {
                    RequestOption = criteria?.RequestType?.RequestOption,
                    SubVersion = criteria?.RequestType?.SubVersion,
                    TransactionReference = criteria?.RequestType?.TransactionReference?.CustomerContext != null ?
                    new Track.TransactionReferenceType
                    {
                        CustomerContext = criteria?.RequestType?.TransactionReference?.CustomerContext
                    } : UPSTrackTransactionReference
                } : new Track.RequestType() { RequestOption = new string[] { "validate" }, TransactionReference = new Track.TransactionReferenceType { CustomerContext = configuration?.Authentication?.CustomerContext ?? Configuration.Authentication.CustomerContext } },
                TrackingOption = criteria?.TrackingOption
            };
            trackRequest.TrackingOption = trackRequest?.TrackingOption ?? configuration?.TrackConfiguration?.TrackingOption ?? Configuration?.TrackConfiguration?.TrackingOption;
            Track.TrackPortTypeClient client = new Track.TrackPortTypeClient();
            if (Configuration.AppSetupConfiguration.WriteXmlRequest)
                WriteXML(trackRequest);
            var response = await client.ProcessTrackAsync(upsSecurity, trackRequest);
            if (Configuration.AppSetupConfiguration.WriteXmlResponse)
                WriteXML(response);
            //var nativeResponse = BuildNativeTrackResponse(response);
            var nativeResponse = BuildResponse<Track.TrackResponse1, NativeTrackResponse>(response, TrackShipmentMapperConfiguration);
            nativeResponse.Message = nativeResponse.IsSuccessful ?
                string.Format(MessageConfiguration.SuccessfulShipmentTracking, criteria?.TrackingReferenceNumber)
                : string.Format(MessageConfiguration.FailedShipmentTracking, criteria?.TrackingReferenceNumber);
            return nativeResponse;
        }        
    }
}
