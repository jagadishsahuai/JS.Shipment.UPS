using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INotificationType
	{
		string NotificationCode { get; set; }
		EmailDetailsType EMail { get; set; }
		ShipmentServiceOptionsNotificationVoiceMessageType VoiceMessage { get; set; }
		ShipmentServiceOptionsNotificationTextMessageType TextMessage { get; set; }
		LocaleType Locale { get; set; }
	}
}
