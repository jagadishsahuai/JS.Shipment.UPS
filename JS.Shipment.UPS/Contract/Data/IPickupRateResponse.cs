using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupRateResponse
    {
        ResponseType Response { get; set; }
        RateResultType RateResult { get; set; }
        string WeekendServiceTerritoryIndicator { get; set; }
    }
}
