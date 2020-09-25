using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDestinationPortDetailType
    {
        string DestinationPort { get; set; }
        DateTimeType EstimatedArrival { get; set; }
    }
}
