using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IResponseImageDetailType
    {
        ImageFormatCodeType ImageFormat { get; set; }
        string GraphicImage { get; set; }
    }
}
