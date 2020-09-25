using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ResponseImageType: IResponseImageType
    {
        public ResponseImageDetailType Image { get; set; }
    }
}
