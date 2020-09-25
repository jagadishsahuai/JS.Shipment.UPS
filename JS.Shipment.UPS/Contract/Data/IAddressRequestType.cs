namespace JS.Shipment.UPS.Contract.Data
{
    public interface IAddressRequestType
	{
		string PostalCode { get; set; }
		string CountryCode { get; set; }
	}
}
