using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CODStatusType: ICODStatusType
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}