using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPackageResultsType
    {
        string TrackingNumber { get; set; }
        ShipChargeType BaseServiceCharge { get; set; }
        ShipChargeType ServiceOptionsCharges { get; set; }
        LabelType ShippingLabel { get; set; }
        ReceiptType ShippingReceipt { get; set; }
        string USPSPICNumber { get; set; }
        string CN22Number { get; set; }
        AccessorialType[] Accessorial { get; set; }
        FormType Form { get; set; }
        ShipChargeType[] ItemizedCharges { get; set; }
        ShipChargeType[] NegotiatedCharges { get; set; }
    }
}
