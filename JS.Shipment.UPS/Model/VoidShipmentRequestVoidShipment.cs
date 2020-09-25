using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class VoidShipmentRequestVoidShipment: IVoidShipmentRequestVoidShipment
    {
        public string ShipmentIdentificationNumber { get; set; }
        public string[] TrackingNumber { get; set; }
    }
}