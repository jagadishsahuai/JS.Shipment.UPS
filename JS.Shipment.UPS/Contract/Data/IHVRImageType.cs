using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IHVRImageType
    {
        ImageFormatCodeType ImageFormat { get; set; }
        string GraphicImage { get; set; }
    }
}
