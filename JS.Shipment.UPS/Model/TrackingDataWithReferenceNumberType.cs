using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TrackingDataWithReferenceNumberType: ITrackingDataWithReferenceNumberType
    {
        public string TrackingNumber { get; set; }
        public string[] ReferenceNumber { get; set; }
    }
}