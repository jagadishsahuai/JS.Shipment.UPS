using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface ISoldToType
	{
		string Name { get; set; }
		string AttentionName { get; set; }
		string TaxIdentificationNumber { get; set; }
		PhoneType Phone { get; set; }
		string Option { get; set; }
		AddressType Address { get; set; }
		string EMailAddress { get; set; }
	}
}
