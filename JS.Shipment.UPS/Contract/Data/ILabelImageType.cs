using JS.Shipment.UPS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILabelImageType
    {
        string GraphicImage { get; set; }
        string HTMLImage { get; set; }
        LabelImageFormatType LabelImageFormat { get; set; }
        string PDF417 { get; set; }
        string InternationalSignatureGraphicImage { get; set; }
        string URL { get; set; }
    }
}
