using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICODType
	{
		string cODFundsCode { get; set; }
		CurrencyMonetaryType CODAmount { get; set; }
	}
}
