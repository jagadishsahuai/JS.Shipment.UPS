using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IIntermediateConsigneeType
	{
		string CompanyName { get; set; }
		AddressType Address { get; set; }
	}
}
