using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IServiceCenterLocationsType
    {
        DropOffFacilitiesType[] DropOffFacilities { get; set; }
        PickupFacilitiesType PickupFacilities { get; set; }
    }
}
