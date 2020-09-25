using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class IntermediateConsigneeType: IIntermediateConsigneeType
	{
		public string CompanyName { get; set; }
		public AddressType Address { get; set; }
	}
}
