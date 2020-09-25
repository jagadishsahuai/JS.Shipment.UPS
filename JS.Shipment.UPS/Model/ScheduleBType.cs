using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ScheduleBType: IScheduleBType
	{
		public string Number { get; set; }
		public string[] Quantity { get; set; }
	}
}
