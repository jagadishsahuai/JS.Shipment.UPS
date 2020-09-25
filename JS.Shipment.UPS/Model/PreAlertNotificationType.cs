using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PreAlertNotificationType: IPreAlertNotificationType
	{
		public PreAlertEMailMessageType EMailMessageField { get; set; }
		public PreAlertVoiceMessageType VoiceMessageField { get; set; }
		public PreAlertTextMessageType TextMessageField { get; set; }
		public LocaleType LocaleField { get; set; }
	}
}
