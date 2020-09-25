using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PSOCODType: IPSOCODType
	{
		public string CODFundsCode { get; set; }
		public CurrencyMonetaryType CODAmount { get; set; }
	}
}
