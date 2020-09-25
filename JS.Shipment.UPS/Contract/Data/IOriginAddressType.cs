using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IOriginAddressType
    {
        string StreetAddress { get; set; }
        string City { get; set; }
        string StateProvince { get; set; }
        string PostalCode { get; set; }
        string CountryCode { get; set; }
        OriginSearchCriteriaType OriginSearchCriteria { get; set; }
    }
}
