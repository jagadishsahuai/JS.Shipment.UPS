using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface ICompanyInfoType
	{
		string Name { get; set; }
		string AttentionName { get; set; }
		string CompanyDisplayableName { get; set; }
		string TaxIdentificationNumber { get; set; }
		TaxIDCodeDescType TaxIDType { get; set; }
		ShipPhoneType Phone { get; set; }
	}
}
