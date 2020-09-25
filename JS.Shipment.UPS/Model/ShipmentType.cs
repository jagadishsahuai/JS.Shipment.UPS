using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentType: IShipmentType
	{
		public string Description { get; set; }
		public ReturnServiceType ReturnService { get; set; }
		public string DocumentsOnlyIndicator { get; set; }
		public ShipperType Shipper { get; set; }
		public ShipToType ShipTo { get; set; }
		public AlternateDeliveryAddressType AlternateDeliveryAddress { get; set; }
		public ShipFromType ShipFrom { get; set; }
		public PaymentInfoType PaymentInformation { get; set; }
		public FRSPaymentInfoType FRSPaymentInformation { get; set; }
		public FreightShipmentInformationType FreightShipmentInformation { get; set; }
		public string GoodsNotInFreeCirculationIndicator { get; set; }
		public RateInfoType ShipmentRatingOptions { get; set; }
		public string MovementReferenceNumber { get; set; }
		public ReferenceNumberType[] ReferenceNumber { get; set; }
		public ServiceType Service { get; set; }
		public CurrencyMonetaryType InvoiceLineTotal { get; set; }
		public string NumOfPiecesInShipment { get; set; }
		public string USPSEndorsement { get; set; }
		public string MILabelCN22Indicator { get; set; }
		public string SubClassification { get; set; }
		public string CostCenter { get; set; }
		public string CostCenterBarcodeIndicator { get; set; }
		public string PackageID { get; set; }
		public string PackageIDBarcodeIndicator { get; set; }
		public string IrregularIndicator { get; set; }
		public IndicationType[] ShipmentIndicationType { get; set; }
		public string MIDualReturnShipmentKey { get; set; }
		public string MIDualReturnShipmentIndicator { get; set; }
		public string RatingMethodRequestedIndicator { get; set; }
		public string TaxInformationIndicator { get; set; }
		public PromotionalDiscountInformationType PromotionalDiscountInformation { get; set; }
		public DGSignatoryInfoType DGSignatoryInfo { get; set; }
		public string MasterCartonID { get; set; }
		public string MasterCartonIndicator { get; set; }
		public ShipmentTypeShipmentServiceOptions ShipmentServiceOptions { get; set; }
		public PackageType[] Package { get; set; }
	}
}
