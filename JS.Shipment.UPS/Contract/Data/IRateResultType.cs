using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IRateResultType
    {
        DisclaimerType Disclaimer { get; set; }
        string RateType { get; set; }
        string CurrencyCode { get; set; }
        ChargeDetailType[] ChargeDetail { get; set; }
        TaxChargeType[] TaxCharges { get; set; }
        string TotalTax { get; set; }
        string GrandTotalOfAllCharge { get; set; }
        string GrandTotalOfAllIncentedCharge { get; set; }
        string PreTaxTotalCharge { get; set; }
        string PreTaxTotalIncentedCharge { get; set; }
    }
}
