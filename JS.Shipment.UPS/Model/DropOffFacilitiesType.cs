using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DropOffFacilitiesType: IDropOffFacilitiesType
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
        public LocalizedInstructionType[] LocalizedInstruction { get; set; }
        public DistanceType Distance { get; set; }
    }
}