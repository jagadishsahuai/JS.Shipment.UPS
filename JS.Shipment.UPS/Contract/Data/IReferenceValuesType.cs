using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IReferenceValuesType
    {
        ReferenceNumberType ReferenceNumber { get; set; }
        string ShipperNumber { get; set; }
    }
}
