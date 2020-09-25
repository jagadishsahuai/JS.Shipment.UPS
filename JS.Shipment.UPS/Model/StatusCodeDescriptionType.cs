using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class StatusCodeDescriptionType: IStatusCodeDescriptionType
    {
        public string Code { get; set; }
        public string Description { get; set; }
    }
}