using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupCreationRequest : IPickupCreationRequest
    {
        public RequestType Request { get; set; }
        public string RatePickupIndicator { get; set; }
        public string TaxInformationIndicator { get; set; }
        public string UserLevelDiscountIndicator { get; set; }
        public PickupShipperType Shipper { get; set; }
        public PickupDateInfoType PickupDateInfo { get; set; }
        public PickupAddressType PickupAddress { get; set; }
        public string AlternateAddressIndicator { get; set; }
        public PickupPieceType[] PickupPiece { get; set; }
        public PickupWeightType TotalWeight { get; set; }
        public string OverweightIndicator { get; set; }
        public TrackingDataType[] TrackingData { get; set; }
        public TrackingDataWithReferenceNumberType TrackingDataWithReferenceNumber { get; set; }
        public string PaymentMethod { get; set; }
        public string SpecialInstruction { get; set; }
        public string ReferenceNumber { get; set; }
        public FreightOptionsType FreightOptions { get; set; }
        public string ServiceCategory { get; set; }
        public string CashType { get; set; }
        public string ShippingLabelsAvailable { get; set; }
    }
}
