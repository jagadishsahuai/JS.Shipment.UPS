using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class NotificationType: INotificationType
	{
		public string NotificationCode { get; set; }
		public EmailDetailsType EMail { get; set; }
		public ShipmentServiceOptionsNotificationVoiceMessageType VoiceMessage { get; set; }
		public ShipmentServiceOptionsNotificationTextMessageType TextMessage { get; set; }
		public LocaleType Locale { get; set; }
	}
}
