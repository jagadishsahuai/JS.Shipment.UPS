using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CarrierActivityInformationType: ICarrierActivityInformationType
    {
        public string CarrierId { get; set; }
        public string Description { get; set; }
        public string Status { get; set; }
        public DateTimeType Arrival { get; set; }
        public DateTimeType Departure { get; set; }
        public string OriginPort { get; set; }
        public string DestinationPort { get; set; }
    }
}