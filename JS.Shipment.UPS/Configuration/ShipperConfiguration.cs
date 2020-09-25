using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Configuration
{
    public class ShipperConfiguration
    {
        public ShipperType Shipper { get; set; }
        public PackagingType Packaging { get; set; }
        public ServiceType UrgentService { get; set; }
        public ServiceType GeneralService { get; set; }
    }
}
