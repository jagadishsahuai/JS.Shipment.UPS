using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentChargesType
    {
        string RateChart { get; set; }
        ShipChargeType BaseServiceCharge { get; set; }
        ShipChargeType TransportationCharges { get; set; }
        ShipChargeType[] ItemizedCharges { get; set; }
        ShipChargeType ServiceOptionsCharges { get; set; }
        TaxChargeType[] TaxCharges { get; set; }
        ShipChargeType TotalCharges { get; set; }
        ShipChargeType TotalChargesWithTaxes { get; set; }
    }
}
