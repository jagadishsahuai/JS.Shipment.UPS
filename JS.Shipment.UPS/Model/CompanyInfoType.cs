using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class CompanyInfoType : ICompanyInfoType
	{
		public string Name { get; set; }
		public string AttentionName { get; set; }
		public string CompanyDisplayableName { get; set; }
		public string TaxIdentificationNumber { get; set; }
		public TaxIDCodeDescType TaxIDType { get; set; }
		public ShipPhoneType Phone { get; set; }
	}
}
