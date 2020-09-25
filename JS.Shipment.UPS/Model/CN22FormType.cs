using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CN22FormType: ICN22FormType
	{
		public string LabelSize { get; set; }
		public string PrintsPerPage { get; set; }
		public string LabelPrintType { get; set; }
		public string CN22Type { get; set; }
		public string CN22OtherDescription { get; set; }
		public string FoldHereText { get; set; }
		public CN22ContentType[] CN22Content { get; set; }
	}
}
