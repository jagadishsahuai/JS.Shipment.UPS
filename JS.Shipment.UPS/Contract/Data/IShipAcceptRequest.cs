using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipAcceptRequest
    {
        RequestType Request { get; set; }
        string ShipmentDigest { get; set; }
    }
}
