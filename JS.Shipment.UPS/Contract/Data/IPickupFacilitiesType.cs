using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupFacilitiesType
    {
        string Name { get; set; }
        PickupRateAddressType Address { get; set; }
        string SLIC { get; set; }
        string Type { get; set; }
        string Timezone { get; set; }
        string Phone { get; set; }
        string Fax { get; set; }
        DayOfWeekType[] FacilityTime { get; set; }
        string OriginOrDestination { get; set; }
        string AirportCode { get; set; }
        string SortCode { get; set; }
    }
}
