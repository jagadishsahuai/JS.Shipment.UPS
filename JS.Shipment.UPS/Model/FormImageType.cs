using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FormImageType: IFormImageType
    {
        public ImageFormatType ImageFormat { get; set; }
        public string GraphicImage { get; set; }
    }
}