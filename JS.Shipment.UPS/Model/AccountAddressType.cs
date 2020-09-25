using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AccountAddressType : IAccountAddressType
	{
		public string PostalCode { get; set; }
		public string CountryCode { get; set; }
	}
}
