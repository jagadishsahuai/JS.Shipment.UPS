using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AddressRequestType: IAddressRequestType
	{
		public string PostalCode { get; set; }
		public string CountryCode { get; set; }
	}
}
