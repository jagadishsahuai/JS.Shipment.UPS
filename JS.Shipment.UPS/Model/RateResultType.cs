using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class RateResultType: IRateResultType
    {
        public DisclaimerType Disclaimer { get; set; }
        public string RateType { get; set; }
        public string CurrencyCode { get; set; }
        public ChargeDetailType[] ChargeDetail { get; set; }
        public TaxChargeType[] TaxCharges { get; set; }
        public string TotalTax { get; set; }
        public string GrandTotalOfAllCharge { get; set; }
        public string GrandTotalOfAllIncentedCharge { get; set; }
        public string PreTaxTotalCharge { get; set; }
        public string PreTaxTotalIncentedCharge { get; set; }
    }
}