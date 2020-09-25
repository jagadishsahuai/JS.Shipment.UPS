using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupCreationRequest
    {
        RequestType Request { get; set; }
        string RatePickupIndicator { get; set; }
        string TaxInformationIndicator { get; set; }
        string UserLevelDiscountIndicator { get; set; }
        PickupShipperType Shipper { get; set; }
        PickupDateInfoType PickupDateInfo { get; set; }
        PickupAddressType PickupAddress { get; set; }
        string AlternateAddressIndicator { get; set; }
        PickupPieceType[] PickupPiece { get; set; }
        PickupWeightType TotalWeight { get; set; }
        string OverweightIndicator { get; set; }
        TrackingDataType[] TrackingData { get; set; }
        TrackingDataWithReferenceNumberType TrackingDataWithReferenceNumber { get; set; }
        string PaymentMethod { get; set; }
        string SpecialInstruction { get; set; }
        string ReferenceNumber { get; set; }
        FreightOptionsType FreightOptions { get; set; }
        string ServiceCategory { get; set; }
        string CashType { get; set; }
        string ShippingLabelsAvailable { get; set; }
    }
}
