using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ImageType: IImageType
    {
        public ImageFormatType ImageFormat { get; set; }
        public string GraphicImage { get; set; }
    }
}