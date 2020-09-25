namespace JS.Shipment.UPS.Contract.Data
{
    public interface IAddressType
	{
		string[] AddressLine { get; set; }
		string City { get; set; }
		string StateProvinceCode { get; set; }
		string Town { get; set; }
		string PostalCode { get; set; }
		string CountryCode { get; set; }
	}
}
