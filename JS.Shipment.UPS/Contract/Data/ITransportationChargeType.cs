using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ITransportationChargeType
    {
        ShipChargeType GrossCharge { get; set; }
        ShipChargeType DiscountAmount { get; set; }
        string DiscountPercentage { get; set; }
        ShipChargeType NetCharge { get; set; }
    }
}
