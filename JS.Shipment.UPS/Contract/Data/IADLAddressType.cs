namespace JS.Shipment.UPS.Contract.Data
{
    public interface IADLAddressType
	{
		string[] AddressLine { get; set; }
		string City { get; set; }
		string StateProvinceCode { get; set; }
		string PostalCode { get; set; }
        string CountryCode { get; set; }
    }
}
