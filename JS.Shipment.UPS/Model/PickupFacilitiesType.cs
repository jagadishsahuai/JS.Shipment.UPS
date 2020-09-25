using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupFacilitiesType: IPickupFacilitiesType
    {
        public string Name { get; set; }
        public PickupRateAddressType Address { get; set; }
        public string SLIC { get; set; }
        public string Type { get; set; }
        public string Timezone { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public DayOfWeekType[] FacilityTime { get; set; }
        public string OriginOrDestination { get; set; }
        public string AirportCode { get; set; }
        public string SortCode { get; set; }
    }
}