using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CN22ContentType: ICN22ContentType
	{
		public string CN22ContentQuantity { get; set; }
		public string CN22ContentDescription { get; set; }
		public ProductWeightType CN22ContentWeight { get; set; }
		public string CN22ContentTotalValue { get; set; }
		public string CN22ContentCurrencyCode { get; set; }
		public string CN22ContentCountryOfOrigin { get; set; }
		public string CN22ContentTariffNumber { get; set; }
	}
}
