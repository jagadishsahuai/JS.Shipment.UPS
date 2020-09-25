using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class VoidShipmentRequest: IVoidShipmentRequest
    {
        public RequestType Request { get; set; }
        public VoidShipmentRequestVoidShipment VoidShipment { get; set; }
    }
}
