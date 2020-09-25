using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class StatusType: IStatusType
    {
        public string Type { get; set; }
        public string Description { get; set; }
        public string Code { get; set; }
    }
}