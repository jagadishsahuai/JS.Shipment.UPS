using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ActivityLocationType: IActivityLocationType
    {
        public AddressType Address { get; set; }
        public TransportFacilityType TransportFacility { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string SignedForByName { get; set; }
    }
}