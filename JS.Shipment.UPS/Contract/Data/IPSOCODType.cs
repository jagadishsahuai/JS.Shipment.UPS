using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPSOCODType
	{
		string CODFundsCode { get; set; }
		CurrencyMonetaryType CODAmount { get; set; }
	}
}
