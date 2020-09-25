using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPackageLevelResult
    {
        string TrackingNumber { get; set; }
        CodeDescriptionType Status { get; set; }
    }
}
