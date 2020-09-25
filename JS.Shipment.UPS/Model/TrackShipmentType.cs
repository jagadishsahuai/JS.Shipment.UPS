using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TrackShipmentType: ITrackShipmentType
    {
        public CodeDescriptionValueType InquiryNumber { get; set; }
        public RefShipmentType ShipmentType1 { get; set; }
        public string CandidateBookmark { get; set; }
        public string ShipperNumber { get; set; }
        public ShipmentAddressType[] ShipmentAddress { get; set; }
        public WeightType ShipmentWeight { get; set; }
        public ServiceType Service { get; set; }
        public ShipmentReferenceNumberType[] ReferenceNumber { get; set; }
        public CommonCodeDescriptionType CurrentStatus { get; set; }
        public string PickupDate { get; set; }
        public ServiceCenterType[] ServiceCenter { get; set; }
        public DeliveryDateUnavailableType DeliveryDateUnavailable { get; set; }
        public DeliveryDetailType[] DeliveryDetail { get; set; }
        public VolumeType Volume { get; set; }
        public string BillToName { get; set; }
        public NumberOfPackagingUnitType[] NumberOfPackagingUnit { get; set; }
        public CODType COD { get; set; }
        public string SignedForByName { get; set; }
        public ShipmentActivityType[] Activity { get; set; }
        public OriginPortDetailType OriginPortDetail { get; set; }
        public DestinationPortDetailType DestinationPortDetail { get; set; }
        public string DescriptionOfGoods { get; set; }
        public DateTimeType CargoReady { get; set; }
        public DateTimeType Manifest { get; set; }
        public CarrierActivityInformationType[] CarrierActivityInformation { get; set; }
        public DocumentType[] Document { get; set; }
        public string FileNumber { get; set; }
        public AppointmentType Appointment { get; set; }
        public TrackPackageType[] Package { get; set; }
        public AdditionalCodeDescriptionValueType[] AdditionalAttribute { get; set; }
    }
}
