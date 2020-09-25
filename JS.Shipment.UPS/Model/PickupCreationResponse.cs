using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupCreationResponse: IPickupCreationResponse
    {
        public ResponseType Response { get; set; }
        public string PRN { get; set; }
        public string WeekendServiceTerritoryIndicator { get; set; }
        public StatusCodeDescriptionType RateStatus { get; set; }
        public RateResultType RateResult { get; set; }
    }
}