using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IForwardAgentType
	{
		string CompanyName { get; set; }
		string TaxIdentificationNumber { get; set; }
		AddressType Address { get; set; }
	}
}
