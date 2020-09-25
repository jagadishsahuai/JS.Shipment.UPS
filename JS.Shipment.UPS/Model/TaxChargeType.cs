using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TaxChargeType: ITaxChargeType
    {
        public string Type { get; set; }
        public string MonetaryValue { get; set; }
    }
}