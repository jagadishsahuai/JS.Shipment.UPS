using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ProducerType: IProducerType
	{
		public string Option { get; set; }
		public string CompanyName { get; set; }
		public string TaxIdentificationNumber { get; set; }
		public AddressType address { get; set; }
		public string attentionName { get; set; }
		public PhoneType Phone { get; set; }
		public string EMailAddress { get; set; }
	}
}
