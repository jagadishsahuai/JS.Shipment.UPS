using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class UPSPremiumCareFormType: IUPSPremiumCareFormType
	{
		public string ShipmentDate { get; set; }
		public string PageSize { get; set; }
		public string PrintType { get; set; }
		public string NumOfCopies { get; set; }
		public string[] LanguageForUPSPremiumCare { get; set; }
	}
}
