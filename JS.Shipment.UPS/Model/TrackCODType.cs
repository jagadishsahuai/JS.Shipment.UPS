using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TrackCODType: ITrackCODType
    {
        public AmountType Amount { get; set; }
        public CODStatusType Status { get; set; }
        public string ControlNumber { get; set; }
    }
}
