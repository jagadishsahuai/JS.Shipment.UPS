using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AmountType: IAmountType
    {
        public string CurrencyCode { get; set; }
        public string MonetaryValue { get; set; }
    }
}