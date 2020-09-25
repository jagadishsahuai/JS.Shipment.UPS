using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PreAlertEMailMessageType: IPreAlertEMailMessageType
	{
		public string EMailAddressField { get; set; }
		public string UndeliverableEMailAddressField { get; set; }
	}
}
