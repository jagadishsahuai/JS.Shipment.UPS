using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DestinationPortDetailType: IDestinationPortDetailType
    {
        public string DestinationPort { get; set; }
        public DateTimeType EstimatedArrival { get; set; }
    }
}