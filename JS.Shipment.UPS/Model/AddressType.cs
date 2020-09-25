using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AddressType: IAddressType
	{
		public string[] AddressLine { get; set; }
		public string City { get; set; }
		public string StateProvinceCode { get; set; }
		public string Town { get; set; }
		public string PostalCode { get; set; }
		public string CountryCode { get; set; }
	}
}
