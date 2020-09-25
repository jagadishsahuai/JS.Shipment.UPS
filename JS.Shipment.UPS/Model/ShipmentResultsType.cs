using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{ 
    public class ShipmentResultsType: IShipmentResultsType
    {
        public DisclaimerType[] Disclaimer { get; set; }
        public ShipmentChargesType ShipmentCharges { get; set; }
        public NegotiatedRateChargesType NegotiatedRateCharges { get; set; }
        public FRSShipmentDataType FRSShipmentData { get; set; }
        public string RatingMethod { get; set; }
        public string BillableWeightCalculationMethod { get; set; }
        public BillingWeightType BillingWeight { get; set; }
        public string ShipmentIdentificationNumber { get; set; }
        public string MIDualReturnShipmentKey { get; set; }
        public string ShipmentDigest { get; set; }
        public PackageResultsType[] PackageResults { get; set; }
        public ImageType[] ControlLogReceipt { get; set; }
        public FormType Form { get; set; }
        public SCReportType CODTurnInPage { get; set; }
        public HighValueReportType HighValueReport { get; set; }
        public string LabelURL { get; set; }
        public string LocalLanguageLabelURL { get; set; }
        public string ReceiptURL { get; set; }
        public string LocalLanguageReceiptURL { get; set; }
        public string[] DGPaperImage { get; set; }
        public string MasterCartonID { get; set; }
    }
}