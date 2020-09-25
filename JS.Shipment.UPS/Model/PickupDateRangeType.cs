using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupDateRangeType: IPickupDateRangeType
	{
        //The beginning pickup date used to narrow a reference number search. Format: YYYYMMDD.
        public string BeginDate { get; set; }
        //The end pickup date used to narrow a reference number search. Format: YYYYMMDD. MM ranges from 01 to 12.
        public string EndDate { get; set; }
	}
}
