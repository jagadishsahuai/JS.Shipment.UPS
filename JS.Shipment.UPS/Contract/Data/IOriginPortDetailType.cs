using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IOriginPortDetailType
    {
        string OriginPort { get; set; }
        DateTimeType EstimatedDeparture { get; set; }
    }
}
