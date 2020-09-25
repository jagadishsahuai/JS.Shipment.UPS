namespace JS.Shipment.UPS.Contract.Data
{
    public interface IChargeCardAddressType
    {
        string[] AddressLine { get; set; }
        string City { get; set; }
        string StateProvince { get; set; }
        string PostalCode { get; set; }
        string CountryCode { get; set; }
    }
}
