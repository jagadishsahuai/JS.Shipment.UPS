using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPackageDeclaredValueType
	{
		DeclaredValueType Type { get; set; }
		string CurrencyCode { get; set; }
		string MonetaryValue { get; set; }
	}
}
