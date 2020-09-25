using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IBillShipperType
	{
		string AccountNumber { get; set; }
		CreditCardType CreditCard { get; set; }
		string AlternatePaymentMethod { get; set; }
	}
}
