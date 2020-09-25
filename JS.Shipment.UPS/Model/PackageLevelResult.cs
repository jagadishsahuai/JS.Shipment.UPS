using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageLevelResult: IPackageLevelResult
    {
        public string TrackingNumber { get; set; }
        public CodeDescriptionType Status { get; set; }
    }
}