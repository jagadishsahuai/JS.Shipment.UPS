using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TrackingDataType: ITrackingDataType
    {
        public string TrackingNumber { get; set; }
    }
}