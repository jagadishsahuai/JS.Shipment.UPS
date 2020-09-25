using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITrackPackageType
    {
        string TrackingNumber { get; set; }
        string DeliveryIndicator { get; set; }
        string DeliveryDate { get; set; }
        RedirectType Redirect { get; set; }
        DeliveryDetailType[] DeliveryDetail { get; set; }
        PackageAddressType[] PackageAddress { get; set; }
        ServiceOptionType[] PackageServiceOption { get; set; }
        TrackCODType COD { get; set; }
        ActivityType[] Activity { get; set; }
        MessageType[] Message { get; set; }
        WeightType PackageWeight { get; set; }
        ReferenceNumberType[] ReferenceNumber { get; set; }
        string[] AlternateTrackingNumber { get; set; }
        AlternateTrackingInfoType[] AlternateTrackingInfo { get; set; }
        string DimensionalWeightScanIndicator { get; set; }
    }
}
