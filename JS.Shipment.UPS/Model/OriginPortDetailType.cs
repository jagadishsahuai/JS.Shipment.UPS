using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class OriginPortDetailType: IOriginPortDetailType
    {
        public string OriginPort { get; set; }
        public DateTimeType EstimatedDeparture { get; set; }
    }
}