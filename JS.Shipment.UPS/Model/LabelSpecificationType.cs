using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelSpecificationType: ILabelSpecificationType
	{
		public LabelImageFormatType LabelImageFormat { get; set; }
		public string HTTPUserAgent { get; set; }
		public LabelStockSizeType LabelStockSize { get; set; }
		public InstructionCodeDescriptionType[] Instruction { get; set; }
		public string CharacterSet { get; set; }
	}
}
