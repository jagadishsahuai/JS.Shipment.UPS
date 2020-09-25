using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FRSPaymentInfoType : IFRSPaymentInfoType
	{
		public PaymentType Type { get; set; }
		public string AccountNumber { get; set; }
		public AccountAddressType Address { get; set; }
	}
}
