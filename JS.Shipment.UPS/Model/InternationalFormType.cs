using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class InternationalFormType: IInternationalFormType
	{
		public string[] FormType { get; set; }
		public string[] UserCreatedForm { get; set; }
		public CN22FormType CN22Form { get; set; }
		public UPSPremiumCareFormType UPSPremiumCareForm { get; set; }
		public string AdditionalDocumentIndicator { get; set; }
		public string FormGroupIdName { get; set; }
		public string SEDFilingOption { get; set; }
		public EEIFilingOptionType EEIFilingOption { get; set; }
		public ContactType Contacts { get; set; }
		public ProductType[] Product { get; set; }
		public string InvoiceNumber { get; set; }
		public string InvoiceDate { get; set; }
		public string PurchaseOrderNumber { get; set; }
		public string TermsOfShipment { get; set; }
		public string ReasonForExport { get; set; }
		public string Comments { get; set; }
		public string DeclarationStatement { get; set; }
		public IFChargesType Discount { get; set; }
		public IFChargesType FreightCharges { get; set; }
		public IFChargesType InsuranceCharges { get; set; }
		public OtherChargesType OtherCharges { get; set; }
		public string CurrencyCode { get; set; }
		public BlanketPeriodType BlanketPeriod { get; set; }
		public string ExportDate { get; set; }
		public string ExportingCarrier { get; set; }
		public string CarrierID { get; set; }
		public string InBondCode { get; set; }
		public string EntryNumber { get; set; }
		public string PointOfOrigin { get; set; }
		public string PointOfOriginType { get; set; }
		public string ModeOfTransport { get; set; }
		public string PortOfExport { get; set; }
		public string PortOfUnloading { get; set; }
		public string LoadingPier { get; set; }
		public string PartiesToTransaction { get; set; }
		public string RoutedExportTransactionIndicator { get; set; }
		public string ContainerizedIndicator { get; set; }
		public LicenseType License { get; set; }
		public string ECCNNumber { get; set; }
		public string OverridePaperlessIndicator { get; set; }
		public string ShipperMemo { get; set; }
		public string multiCurrencyInvoiceLineTotal { get; set; }
		public string HazardousMaterialsIndicator { get; set; }
	}
}
