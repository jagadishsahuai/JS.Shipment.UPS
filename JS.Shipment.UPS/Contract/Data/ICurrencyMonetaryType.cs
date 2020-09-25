namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICurrencyMonetaryType
	{
		string CurrencyCode { get; set; }
		string MonetaryValue { get; set; }
	}
}
