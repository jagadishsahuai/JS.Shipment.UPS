using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentReferenceNumberType: IShipmentReferenceNumberType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
    }
}