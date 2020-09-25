using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Configuration
{
    public class PickupConfiguration
    {
        public int MinimumHoursOffsetForPickupSchedule { get; set; }
        public int MinimumHoursPickupInterval { get; set; }
        public int MinimumHoursOffsetForPickupCancel { get; set; }
        public PickupAddressType PickupAddress { get; set; }
        public string AlternateAddressIndicator { get; set; }
        public string ContainerCode { get; set; }
        public string DestinationCountryCode { get; set; }
        public string Quantity { get; set;}
        public string ServiceCode { get; set; }
    }
}
