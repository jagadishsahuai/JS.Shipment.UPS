using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class OriginAddressType: IOriginAddressType
    {
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public OriginSearchCriteriaType OriginSearchCriteria { get; set; }
    }
}