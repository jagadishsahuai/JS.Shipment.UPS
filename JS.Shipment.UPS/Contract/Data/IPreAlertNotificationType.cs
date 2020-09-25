using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPreAlertNotificationType
	{
		PreAlertEMailMessageType EMailMessageField { get; set; }
		PreAlertVoiceMessageType VoiceMessageField { get; set; }
		PreAlertTextMessageType TextMessageField { get; set; }
		LocaleType LocaleField { get; set; }
	}
}
