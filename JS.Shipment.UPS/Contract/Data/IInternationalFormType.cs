using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IInternationalFormType
	{
		string[] FormType { get; set; }
		string[] UserCreatedForm { get; set; }
		CN22FormType CN22Form { get; set; }
		UPSPremiumCareFormType UPSPremiumCareForm { get; set; }
		string AdditionalDocumentIndicator { get; set; }
		string FormGroupIdName { get; set; }
		string SEDFilingOption { get; set; }
		EEIFilingOptionType EEIFilingOption { get; set; }
		ContactType Contacts { get; set; }
		ProductType[] Product { get; set; }
		string InvoiceNumber { get; set; }
		string InvoiceDate { get; set; }
		string PurchaseOrderNumber { get; set; }
		string TermsOfShipment { get; set; }
		string ReasonForExport { get; set; }
		string Comments { get; set; }
		string DeclarationStatement { get; set; }
		IFChargesType Discount { get; set; }
		IFChargesType FreightCharges { get; set; }
		IFChargesType InsuranceCharges { get; set; }
		OtherChargesType OtherCharges { get; set; }
		string CurrencyCode { get; set; }
		BlanketPeriodType BlanketPeriod { get; set; }
		string ExportDate { get; set; }
		string ExportingCarrier { get; set; }
		string CarrierID { get; set; }
		string InBondCode { get; set; }
		string EntryNumber { get; set; }
		string PointOfOrigin { get; set; }
		string PointOfOriginType { get; set; }
		string ModeOfTransport { get; set; }
		string PortOfExport { get; set; }
		string PortOfUnloading{ get; set; }
		string LoadingPier { get; set; }
		string PartiesToTransaction { get; set; }
		string RoutedExportTransactionIndicator { get; set; }
		string ContainerizedIndicator { get; set; }
		LicenseType License { get; set; }
		string ECCNNumber { get; set; }
		string OverridePaperlessIndicator { get; set; }
		string ShipperMemo { get; set; }
		string multiCurrencyInvoiceLineTotal { get; set; }
		string HazardousMaterialsIndicator { get; set; }
	}
}
