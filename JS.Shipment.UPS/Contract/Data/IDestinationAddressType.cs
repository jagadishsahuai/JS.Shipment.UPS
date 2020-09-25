namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDestinationAddressType
    {
        string City { get; set; }
        string StateProvince { get; set; }
        string PostalCode { get; set; }
        string CountryCode { get; set; }
    }
}
