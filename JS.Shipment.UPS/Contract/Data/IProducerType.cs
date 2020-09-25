using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IProducerType
	{
		string Option { get; set; }
		string CompanyName { get; set; }
		string TaxIdentificationNumber { get; set; }
		AddressType address { get; set; }
		string attentionName { get; set; }
		PhoneType Phone { get; set; }
		string EMailAddress { get; set; }
	}
}
