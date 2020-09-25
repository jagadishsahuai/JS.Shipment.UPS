using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupGetPoliticalDivision1ListRequest
    {
        RequestType Request { get; set; }
        string CountryCode { get; set; }
    }
}
