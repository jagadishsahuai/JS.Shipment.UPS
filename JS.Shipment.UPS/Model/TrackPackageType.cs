using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TrackPackageType: ITrackPackageType
    {
        public string TrackingNumber { get; set; }
        public string DeliveryIndicator { get; set; }
        public string DeliveryDate { get; set; }
        public RedirectType Redirect { get; set; }
        public DeliveryDetailType[] DeliveryDetail { get; set; }
        public PackageAddressType[] PackageAddress { get; set; }
        public ServiceOptionType[] PackageServiceOption { get; set; }
        public TrackCODType COD { get; set; }
        public ActivityType[] Activity { get; set; }
        public MessageType[] Message { get; set; }
        public WeightType PackageWeight { get; set; }
        public ReferenceNumberType[] ReferenceNumber { get; set; }
        public string[] AlternateTrackingNumber { get; set; }
        public AlternateTrackingInfoType[] AlternateTrackingInfo { get; set; }
        public string DimensionalWeightScanIndicator { get; set; }
    }
}