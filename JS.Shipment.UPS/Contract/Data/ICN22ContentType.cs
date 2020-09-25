using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICN22ContentType
	{
		string CN22ContentQuantity { get; set; }
		string CN22ContentDescription { get; set; }
		ProductWeightType CN22ContentWeight { get; set; }
		string CN22ContentTotalValue { get; set; }
		string CN22ContentCurrencyCode { get; set; }
		string CN22ContentCountryOfOrigin { get; set; }
		string CN22ContentTariffNumber { get; set; }
	}
}
