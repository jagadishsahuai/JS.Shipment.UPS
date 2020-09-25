using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LabelDeliveryType : ILabelDeliveryType
	{
		public EmailDetailsType EMail { get; set; }
		public string LabelLinksIndicator { get; set; }
        public string LabelLinkIndicator { get; set; }
    }
}
