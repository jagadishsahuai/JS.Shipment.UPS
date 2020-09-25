using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CreditCardType : ICreditCardType
	{
		public string Type { get; set; }
		public string Number { get; set; }
		public string ExpirationDate { get; set; }
		public string SecurityCode { get; set; }
		public CreditCardAddressType Address { get; set; }
	}
}
