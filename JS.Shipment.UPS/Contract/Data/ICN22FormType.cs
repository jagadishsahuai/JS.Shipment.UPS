using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICN22FormType
	{
		string LabelSize { get; set; }
		string PrintsPerPage { get; set; }
		string LabelPrintType { get; set; }
		string CN22Type { get; set; }
		string CN22OtherDescription { get; set; }
		string FoldHereText { get; set; }
		CN22ContentType[] CN22Content { get; set; }
	}
}
