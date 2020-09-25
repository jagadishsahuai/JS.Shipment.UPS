using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Configuration
{
    public class ShipmentConfiguration
    {
        public bool UseShipperConfiguration { get; set; }
        public bool UseShippingChargesPaymentConfiguration { get; set; }
        public int MaximumPackageAllowedForAnyShipment { get; set; }
        public int MaximumTotalWeightInLBForAllPackageAllowed { get; set; }
        public string GeneralServiceCode { get; set; }
        public string UrgentServiceCode { get; set; }
        public string Description { get; set; }
        public PackagingType Packaging { get; set; }
        public int MinimumHoursOffsetForSameDayShipment { get; set; }
        public ServiceTypeConfiguration[] ServiceTypes { get; set; }
    }
}
