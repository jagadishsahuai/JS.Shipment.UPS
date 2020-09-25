using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILabelDeliveryType
	{
		EmailDetailsType EMail { get; set; }
		string LabelLinksIndicator { get; set; }
	}
}
