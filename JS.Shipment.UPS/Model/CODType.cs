using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CODType : ICODType
	{
		public string cODFundsCode { get; set; }
		public CurrencyMonetaryType CODAmount { get; set; }
	}
}
