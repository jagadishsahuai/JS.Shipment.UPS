using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class BlanketPeriodType: IBlanketPeriodType
	{
		public string BeginDate { get; set; }
		public string EndDate { get; set; }
	}
}
