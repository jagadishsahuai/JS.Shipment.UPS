using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class OriginSearchCriteriaType: IOriginSearchCriteriaType
    {
        public string SearchRadius { get; set; }
        public string DistanceUnitOfMeasure { get; set; }
        public string MaximumLocation { get; set; }
    }
}