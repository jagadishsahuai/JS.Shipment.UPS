using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class BillShipperType : IBillShipperType
	{
		public string AccountNumber { get; set; }
		public CreditCardType CreditCard { get; set; }
		public string AlternatePaymentMethod { get; set; }
	}
}
