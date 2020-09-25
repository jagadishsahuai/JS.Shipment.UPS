using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipConfirmResponse
    {
        ResponseType Response { get; set; }
        ShipmentResultsType ShipmentResults { get; set; }
    }
}
