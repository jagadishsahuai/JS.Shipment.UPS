using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPSONotificationType
	{
		string NotificationCode { get; set; }
		EmailDetailsType EMail { get; set; }
	}
}
