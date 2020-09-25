using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IContactType
	{
		ForwardAgentType ForwardAgent { get; set; }
		UltimateConsigneeType UltimateConsignee { get; set; }
		IntermediateConsigneeType IntermediateConsignee { get; set; }
		ProducerType Producer { get; set; }
		SoldToType SoldTo { get; set; }
	}
}
