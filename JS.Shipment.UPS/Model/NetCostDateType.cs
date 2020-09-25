using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class NetCostDateType: INetCostDateType
	{
		public string BeginDateField { get; set; }
		public string EndDateField { get; set; }
	}
}
