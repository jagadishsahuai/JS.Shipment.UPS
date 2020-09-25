using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativePickupRateResponse : INativePickupRateResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(PickupRateResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public string DisclaimerCode { get { return PickupRateResponse?.RateResult?.Disclaimer?.Code; } }
        [AutoMapper.IgnoreMap]
        public string DisclaimerDescription { get { return PickupRateResponse?.RateResult?.Disclaimer?.Description; } }
        [AutoMapper.IgnoreMap]
        public string RateType { get { return PickupRateResponse?.RateResult?.RateType; } }
        [AutoMapper.IgnoreMap]
        public string CurrencyCode { get { return PickupRateResponse?.RateResult?.CurrencyCode; } }
        [AutoMapper.IgnoreMap]
        public ChargeDetailType[] ChargeDetails { get { return PickupRateResponse?.RateResult?.ChargeDetail; } }
        [AutoMapper.IgnoreMap]
        public TaxChargeType[] TaxCharges { get { return PickupRateResponse?.RateResult?.TaxCharges; } }
        [AutoMapper.IgnoreMap]
        public string TotalTax { get { return PickupRateResponse?.RateResult?.TotalTax; } }
        [AutoMapper.IgnoreMap]
        public string GrandTotalOfAllCharge { get { return PickupRateResponse?.RateResult?.GrandTotalOfAllCharge; } }
        [AutoMapper.IgnoreMap]
        public string GrandTotalOfAllIncentedCharge { get { return PickupRateResponse?.RateResult?.GrandTotalOfAllIncentedCharge; } }
        [AutoMapper.IgnoreMap]
        public string PreTaxTotalCharge { get { return PickupRateResponse?.RateResult?.PreTaxTotalCharge; } }
        [AutoMapper.IgnoreMap]
        public string PreTaxTotalIncentedCharge { get { return PickupRateResponse?.RateResult?.PreTaxTotalIncentedCharge; } }
        [AutoMapper.IgnoreMap]
        public string WeekendServiceTerritoryIndicator { get { return PickupRateResponse?.WeekendServiceTerritoryIndicator; } }
        public PickupRateResponse PickupRateResponse { get; set; }
    }
}
