using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LocaleType : ILocaleType
	{
		public string Language { get; set; }
		public string Dialect { get; set; }
	}
}
