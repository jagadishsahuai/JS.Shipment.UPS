using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelImageType: ILabelImageType
    {        
        public string GraphicImage { get; set; }
        public string HTMLImage { get; set; }
        public LabelImageFormatType LabelImageFormat { get; set; }
        public string PDF417 { get; set; }
        public string InternationalSignatureGraphicImage { get; set; }
        public string URL { get; set; }
    }
}
