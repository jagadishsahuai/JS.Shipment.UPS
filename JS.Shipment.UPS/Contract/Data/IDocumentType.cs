using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IDocumentType
    {
        CommonCodeDescriptionType Type { get; set; }
        string Content { get; set; }
        CommonCodeDescriptionType Format { get; set; }
    }
}
