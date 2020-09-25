using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IFormImageType
    {
        ImageFormatType ImageFormat { get; set; }
        string GraphicImage { get; set; }
    }
}
