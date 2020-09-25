using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ReferenceValuesType: IReferenceValuesType
    {
        public ReferenceNumberType ReferenceNumber { get; set; }
        public string ShipperNumber { get; set; }
    }
}