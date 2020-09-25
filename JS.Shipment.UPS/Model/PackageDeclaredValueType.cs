using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageDeclaredValueType: IPackageDeclaredValueType
	{
		public DeclaredValueType Type { get; set; }
		public string CurrencyCode { get; set; }
		public string MonetaryValue { get; set; }
	}
}
