namespace JS.Shipment.UPS.Contract.Data
{
    public interface IOriginSearchCriteriaType
    {
        string SearchRadius { get; set; }
        string DistanceUnitOfMeasure { get; set; }
        string MaximumLocation { get; set; }
    }
}
