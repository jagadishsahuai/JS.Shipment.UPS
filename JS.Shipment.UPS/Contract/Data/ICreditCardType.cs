using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICreditCardType
	{
		string Type { get; set; }
		string Number { get; set; }
		string ExpirationDate { get; set; }
		string SecurityCode { get; set; }
        CreditCardAddressType Address { get; set; }
    }
}
