using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class NegotiatedRateChargesType: INegotiatedRateChargesType
    {
        public ShipChargeType[] ItemizedCharges { get; set; }
        public TaxChargeType[] TaxCharges { get; set; }
        public ShipChargeType TotalCharge { get; set; }
        public ShipChargeType TotalChargesWithTaxes { get; set; }
    }
}