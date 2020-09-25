using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class HVRImageType: IHVRImageType
    {
        public ImageFormatCodeType ImageFormat { get; set; }
        public string GraphicImage { get; set; }
    }
}
