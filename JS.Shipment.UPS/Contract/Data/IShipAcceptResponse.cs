using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipAcceptResponse
    {
        ResponseType Response { get; set; }
        ShipmentResultsType ShipmentResults { get; set; }
    }
}
