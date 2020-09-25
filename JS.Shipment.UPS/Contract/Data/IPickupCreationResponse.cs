using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupCreationResponse
    {
        ResponseType Response { get; set; }
        string PRN { get; set; }
        string WeekendServiceTerritoryIndicator { get; set; }
        StatusCodeDescriptionType RateStatus { get; set; }
        RateResultType RateResult { get; set; }
    }
}
