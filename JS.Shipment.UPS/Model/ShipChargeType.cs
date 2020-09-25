using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipChargeType: IShipChargeType
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string CurrencyCode { get; set; }
        public string MonetaryValue { get; set; }
        public string SubType { get; set; }
    }
}