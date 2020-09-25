using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICarrierActivityInformationType
    {
        string CarrierId { get; set; }
        string Description { get; set; }
        string Status { get; set; }
        DateTimeType Arrival { get; set; }
        DateTimeType Departure { get; set; }
        string OriginPort { get; set; }
        string DestinationPort { get; set; }
    }
}
