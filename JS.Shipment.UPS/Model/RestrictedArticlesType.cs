using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class RestrictedArticlesType: IRestrictedArticlesType
	{
		public string DiagnosticSpecimensIndicatorField { get; set; }
		public string AlcoholicBeveragesIndicatorField { get; set; }
		public string PerishablesIndicatorField { get; set; }
		public string PlantsIndicatorField { get; set; }
		public string SeedsIndicatorField { get; set; }
		public string SpecialExceptionsIndicatorField { get; set; }
		public string TobaccoIndicatorField { get; set; }
	}
}
