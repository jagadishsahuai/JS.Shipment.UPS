using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupAddressType: IPickupAddressType
    {
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string[] AddressLine { get; set; }
        public string Room { get; set; }
        public string Floor { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string Urbanization { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string ResidentialIndicator { get; set; }
        public string PickupPoint { get; set; }
        public PhoneType Phone { get; set; }
    }
}