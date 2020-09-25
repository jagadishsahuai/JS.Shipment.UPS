using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITrackShipmentType
    {
        CodeDescriptionValueType InquiryNumber { get; set; }
        RefShipmentType ShipmentType1 { get; set; }
        string CandidateBookmark { get; set; }
        string ShipperNumber { get; set; }
        ShipmentAddressType[] ShipmentAddress { get; set; }
        WeightType ShipmentWeight { get; set; }
        ServiceType Service { get; set; }
        ShipmentReferenceNumberType[] ReferenceNumber { get; set; }
        CommonCodeDescriptionType CurrentStatus { get; set; }
        string PickupDate { get; set; }
        ServiceCenterType[] ServiceCenter { get; set; }
        DeliveryDateUnavailableType DeliveryDateUnavailable { get; set; }
        DeliveryDetailType[] DeliveryDetail { get; set; }
        VolumeType Volume { get; set; }
        string BillToName { get; set; }
        NumberOfPackagingUnitType[] NumberOfPackagingUnit { get; set; }
        CODType COD { get; set; }
        string SignedForByName { get; set; }
        ShipmentActivityType[] Activity { get; set; }
        OriginPortDetailType OriginPortDetail { get; set; }
        DestinationPortDetailType DestinationPortDetail { get; set; }
        string DescriptionOfGoods { get; set; }
        DateTimeType CargoReady { get; set; }
        DateTimeType Manifest { get; set; }
        CarrierActivityInformationType[] CarrierActivityInformation { get; set; }
        DocumentType[] Document { get; set; }
        string FileNumber { get; set; }
        AppointmentType Appointment { get; set; }
        TrackPackageType[] Package { get; set; }
        AdditionalCodeDescriptionValueType[] AdditionalAttribute { get; set; }
    }
}
