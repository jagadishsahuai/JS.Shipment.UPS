using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IActivityType
    {
        AlternateTrackingInfoType[] AlternateTrackingInfo { get; set; }
        ActivityLocationType ActivityLocation { get; set; }
        StatusType Status { get; set; }
        string Date { get; set; }
        string Time { get; set; }
        string DeliveryDateFromManifestIndicator { get; set; }
        NextScheduleActivityType NextScheduleActivity { get; set; }
        DocumentType[] Document { get; set; }
        AdditionalCodeDescriptionValueType[] AdditionalAttribute { get; set; }
    }
}
