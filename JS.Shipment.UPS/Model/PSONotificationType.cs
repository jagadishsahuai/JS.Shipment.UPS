using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PSONotificationType: IPSONotificationType
	{
		public string NotificationCode { get; set; }
		public EmailDetailsType EMail { get; set; }
	}
}
