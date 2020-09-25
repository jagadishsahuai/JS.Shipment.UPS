using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TransportationChargeType: ITransportationChargeType
    {
        public ShipChargeType GrossCharge { get; set; }
        public ShipChargeType DiscountAmount { get; set; }
        public string DiscountPercentage { get; set; }
        public ShipChargeType NetCharge { get; set; }
    }
}