using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AlternateDeliveryAddressType : IAlternateDeliveryAddressType
	{
		public string Name { get; set; }
		public string AttentionName { get; set; }
		public string UPSAccessPointID { get; set; }
		public ADLAddressType Address { get; set; }
	}
}
