using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipmentChargesType: IShipmentChargesType
    {
        public string RateChart { get; set; }
        public ShipChargeType BaseServiceCharge { get; set; }
        public ShipChargeType TransportationCharges { get; set; }
        public ShipChargeType[] ItemizedCharges { get; set; }
        public ShipChargeType ServiceOptionsCharges { get; set; }
        public TaxChargeType[] TaxCharges { get; set; }
        public ShipChargeType TotalCharges { get; set; }
        public ShipChargeType TotalChargesWithTaxes { get; set; }
    }
}