using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentType
	{
		 string Description { get; set; }
		 ReturnServiceType ReturnService { get; set; }
		string DocumentsOnlyIndicator { get; set; }
		ShipperType Shipper { get; set; }
		ShipToType ShipTo { get; set; }
		AlternateDeliveryAddressType AlternateDeliveryAddress { get; set; }
		ShipFromType ShipFrom { get; set; }
		PaymentInfoType PaymentInformation { get; set; }
		FRSPaymentInfoType FRSPaymentInformation { get; set; }
		FreightShipmentInformationType FreightShipmentInformation { get; set; }
		string GoodsNotInFreeCirculationIndicator { get; set; }
		RateInfoType ShipmentRatingOptions { get; set; }
		string MovementReferenceNumber { get; set; }
		ReferenceNumberType[] ReferenceNumber { get; set; }
		ServiceType Service { get; set; }
		CurrencyMonetaryType InvoiceLineTotal { get; set; }
		string NumOfPiecesInShipment{ get; set; }
		string USPSEndorsement { get; set; }
		string MILabelCN22Indicator { get; set; }
		string SubClassification { get; set; }
		string CostCenter { get; set; }
		string CostCenterBarcodeIndicator { get; set; }
		string PackageID { get; set; }
		string PackageIDBarcodeIndicator { get; set; }
		string IrregularIndicator { get; set; }
		IndicationType[] ShipmentIndicationType { get; set; }
		string MIDualReturnShipmentKey { get; set; }
		string MIDualReturnShipmentIndicator { get; set; }
		string RatingMethodRequestedIndicator { get; set; }
		string TaxInformationIndicator { get; set; }
		PromotionalDiscountInformationType PromotionalDiscountInformation { get; set; }
		DGSignatoryInfoType DGSignatoryInfo { get; set; }
		string MasterCartonID { get; set; }
		string MasterCartonIndicator { get; set; }
		ShipmentTypeShipmentServiceOptions ShipmentServiceOptions { get; set; }
		PackageType[] Package { get; set; }
	}
}
