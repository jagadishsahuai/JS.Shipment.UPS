using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelMethodType: ILabelMethodType
	{
		public string CodeField { get; set; }
		public string DescriptionField { get; set; }
	}
}
