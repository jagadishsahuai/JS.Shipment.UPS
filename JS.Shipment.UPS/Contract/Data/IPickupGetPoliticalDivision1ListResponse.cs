using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupGetPoliticalDivision1ListResponse
    {
        ResponseType Response { get; set; }
        string[] PoliticalDivision1 { get; set; }
    }
}
