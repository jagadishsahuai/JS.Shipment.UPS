using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ContactType : IContactType
	{
		public ForwardAgentType ForwardAgent { get; set; }
		public UltimateConsigneeType UltimateConsignee { get; set; }
		public IntermediateConsigneeType IntermediateConsignee { get; set; }
		public ProducerType Producer { get; set; }
		public SoldToType SoldTo { get; set; }
	}
}
