namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupDateRangeType
	{
        //The beginning pickup date used to narrow a reference number search. Format: YYYYMMDD.
        string BeginDate { get; set; }
        //The end pickup date used to narrow a reference number search. Format: YYYYMMDD. MM ranges from 01 to 12.
        string EndDate { get; set; }
    }
}
