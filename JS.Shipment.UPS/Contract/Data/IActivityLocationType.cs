using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IActivityLocationType
    {
        AddressType Address { get; set; }
        TransportFacilityType TransportFacility { get; set; }
        string Code { get; set; }
        string Description { get; set; }
        string SignedForByName { get; set; }
    }
}
