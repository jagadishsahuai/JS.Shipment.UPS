using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelType: ImageType, ILabelType
    {
        public string[] GraphicImagePart { get; set; }
        public string InternationalSignatureGraphicImage { get; set; }
        public string HTMLImage { get; set; }
        public string PDF417 { get; set; }
    }
}