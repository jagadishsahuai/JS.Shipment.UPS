namespace JS.Shipment.UPS.Contract.Data
{
    public interface IRestrictedArticlesType
	{
		string DiagnosticSpecimensIndicatorField { get; set; }
		string AlcoholicBeveragesIndicatorField { get; set; }
		string PerishablesIndicatorField { get; set; }
		string PlantsIndicatorField { get; set; }
		string SeedsIndicatorField { get; set; }
		string SpecialExceptionsIndicatorField { get; set; }
		string TobaccoIndicatorField { get; set; }
	}
}
