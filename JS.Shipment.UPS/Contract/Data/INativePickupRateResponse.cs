using JS.Shipment.UPS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativePickupRateResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        [AutoMapper.IgnoreMap]
        string DisclaimerCode { get; }
        [AutoMapper.IgnoreMap]
        string DisclaimerDescription { get; }
        [AutoMapper.IgnoreMap]
        string RateType { get; }
        [AutoMapper.IgnoreMap]
        string CurrencyCode { get; }
        [AutoMapper.IgnoreMap]
        ChargeDetailType[] ChargeDetails { get; }
        [AutoMapper.IgnoreMap]
        TaxChargeType[] TaxCharges { get; }
        [AutoMapper.IgnoreMap]
        string TotalTax { get; }
        [AutoMapper.IgnoreMap]
        string GrandTotalOfAllCharge { get; }
        [AutoMapper.IgnoreMap]
        string GrandTotalOfAllIncentedCharge { get; }
        [AutoMapper.IgnoreMap]
        string PreTaxTotalCharge { get; }
        [AutoMapper.IgnoreMap]
        string PreTaxTotalIncentedCharge { get; }
        [AutoMapper.IgnoreMap]
        string WeekendServiceTerritoryIndicator { get; }
        PickupRateResponse PickupRateResponse { get; set; }
    }
}
