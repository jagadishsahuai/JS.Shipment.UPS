using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILabelSpecificationType
	{
		LabelImageFormatType LabelImageFormat { get; set; }
		string HTTPUserAgent { get; set; }
		LabelStockSizeType LabelStockSize { get; set; }
		InstructionCodeDescriptionType[] Instruction { get; set; }
		string CharacterSet { get; set; }
	}
}
