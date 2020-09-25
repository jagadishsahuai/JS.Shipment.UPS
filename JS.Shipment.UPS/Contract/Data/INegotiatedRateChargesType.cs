using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INegotiatedRateChargesType
    {
        ShipChargeType[] ItemizedCharges { get; set; }
        TaxChargeType[] TaxCharges { get; set; }
        ShipChargeType TotalCharge { get; set; }
        ShipChargeType TotalChargesWithTaxes { get; set; }
    }
}
