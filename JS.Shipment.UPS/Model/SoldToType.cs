using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class SoldToType: ISoldToType
	{
		public string Name { get; set; }
		public string AttentionName { get; set; }
		public string TaxIdentificationNumber { get; set; }
		public PhoneType Phone { get; set; }
		public string Option { get; set; }
		public AddressType Address { get; set; }
		public string EMailAddress { get; set; }
	}
}
