using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TransportFacilityType: ITransportFacilityType
    {
        public string Type { get; set; }
        public string Code { get; set; }
    }
}