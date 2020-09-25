using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IVoidShipmentRequest
    {
        RequestType Request { get; set; }
        VoidShipmentRequestVoidShipment VoidShipment { get; set; }
    }
}
