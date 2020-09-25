using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentResultsType
    {
        DisclaimerType[] Disclaimer { get; set; }
        ShipmentChargesType ShipmentCharges { get; set; }
        NegotiatedRateChargesType NegotiatedRateCharges { get; set; }
        FRSShipmentDataType FRSShipmentData { get; set; }
        string RatingMethod { get; set; }
        string BillableWeightCalculationMethod { get; set; }
        BillingWeightType BillingWeight { get; set; }
        string ShipmentIdentificationNumber { get; set; }
        string MIDualReturnShipmentKey { get; set; }
        string ShipmentDigest { get; set; }
        PackageResultsType[] PackageResults { get; set; }
        ImageType[] ControlLogReceipt { get; set; }
        FormType Form { get; set; }
        SCReportType CODTurnInPage { get; set; }
        HighValueReportType HighValueReport { get; set; }
        string LabelURL { get; set; }
        string LocalLanguageLabelURL { get; set; }
        string ReceiptURL { get; set; }
        string LocalLanguageReceiptURL { get; set; }
        string[] DGPaperImage { get; set; }
        string MasterCartonID { get; set; }
    }
}
