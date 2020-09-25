using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ActivityType: IActivityType
    {
        public AlternateTrackingInfoType[] AlternateTrackingInfo { get; set; }
        public ActivityLocationType ActivityLocation { get; set; }
        public StatusType Status { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string DeliveryDateFromManifestIndicator { get; set; }
        public NextScheduleActivityType NextScheduleActivity { get; set; }
        public DocumentType[] Document { get; set; }
        public AdditionalCodeDescriptionValueType[] AdditionalAttribute { get; set; }
    }
}