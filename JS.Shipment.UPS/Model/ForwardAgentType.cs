using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ForwardAgentType: IForwardAgentType
	{
		public string CompanyName { get; set; }
		public string TaxIdentificationNumber { get; set; }
		public AddressType Address { get; set; }
	}
}
