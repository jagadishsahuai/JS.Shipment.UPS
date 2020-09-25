using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ServiceCenterLocationsType: IServiceCenterLocationsType
    {
        public DropOffFacilitiesType[] DropOffFacilities { get; set; }
        public PickupFacilitiesType PickupFacilities { get; set; }
    }
}