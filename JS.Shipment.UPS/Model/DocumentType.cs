using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DocumentType: IDocumentType
    {
        public CommonCodeDescriptionType Type { get; set; }
        public string Content { get; set; }
        public CommonCodeDescriptionType Format { get; set; }
    }
}