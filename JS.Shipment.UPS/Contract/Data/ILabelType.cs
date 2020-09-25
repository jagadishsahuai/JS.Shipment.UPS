namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILabelType: IImageType
    {
        string[] GraphicImagePart { get; set; }
        string InternationalSignatureGraphicImage { get; set; }
        string HTMLImage { get; set; }
        string PDF417 { get; set; }
    }
}
