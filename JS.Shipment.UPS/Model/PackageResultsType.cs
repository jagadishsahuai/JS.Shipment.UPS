using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageResultsType: IPackageResultsType
    {
        public string TrackingNumber { get; set; }
        public ShipChargeType BaseServiceCharge { get; set; }
        public ShipChargeType ServiceOptionsCharges { get; set; }
        public LabelType ShippingLabel { get; set; }
        public ReceiptType ShippingReceipt { get; set; }
        public string USPSPICNumber { get; set; }
        public string CN22Number { get; set; }
        public AccessorialType[] Accessorial { get; set; }
        public FormType Form { get; set; }
        public ShipChargeType[] ItemizedCharges { get; set; }
        public ShipChargeType[] NegotiatedCharges { get; set; }
    }
}