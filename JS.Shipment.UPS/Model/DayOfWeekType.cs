using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DayOfWeekType: IDayOfWeekType
    {
        public string Day { get; set; }
        public string EarliestDropOfforPickup { get; set; }
        public string LatestDropOfforPickup { get; set; }
        public string OpenHours { get; set; }
        public string CloseHours { get; set; }
        public string PrepTime { get; set; }
        public string LastDrop { get; set; }
    }
}