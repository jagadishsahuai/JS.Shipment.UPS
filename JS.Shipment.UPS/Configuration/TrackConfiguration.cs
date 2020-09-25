namespace JS.Shipment.UPS.Configuration
{
    public class TrackConfiguration
    {
        public string TrackingDaysOffset { get; set; }
        public string TrackingOption { get; set; }
        public bool TrackDeliveredShipment { get; set; }
        public TrackStatusLookup[] TrackStatusLookup { get; set; }
    }
}
