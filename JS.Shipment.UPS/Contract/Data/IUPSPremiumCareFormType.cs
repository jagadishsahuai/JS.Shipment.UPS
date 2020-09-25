namespace JS.Shipment.UPS.Contract.Data
{
    public interface IUPSPremiumCareFormType
	{
		string ShipmentDate { get; set; }
		string PageSize { get; set; }
		string PrintType { get; set; }
		string NumOfCopies { get; set; }
		string[] LanguageForUPSPremiumCare { get; set; }
	}
}
