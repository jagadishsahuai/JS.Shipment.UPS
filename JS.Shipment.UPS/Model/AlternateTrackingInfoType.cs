using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AlternateTrackingInfoType: IAlternateTrackingInfoType
    {
        public string Type { get; set; }
        public string Value { get; set; }
    }
}