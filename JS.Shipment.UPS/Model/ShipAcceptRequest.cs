using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipAcceptRequest: IShipAcceptRequest
    {
        public RequestType Request { get; set; }
        public string ShipmentDigest { get; set; }
    }
}
