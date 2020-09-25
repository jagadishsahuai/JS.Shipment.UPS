using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IFRSPaymentInfoType
	{
		PaymentType Type { get; set; }
		string AccountNumber { get; set; }
		AccountAddressType Address { get; set; }
	}
}
