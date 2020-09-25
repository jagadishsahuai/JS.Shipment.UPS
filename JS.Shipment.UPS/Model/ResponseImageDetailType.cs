using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ResponseImageDetailType: IResponseImageDetailType
    {
        public ImageFormatCodeType ImageFormat { get; set; }
        public string GraphicImage { get; set; }
    }
}