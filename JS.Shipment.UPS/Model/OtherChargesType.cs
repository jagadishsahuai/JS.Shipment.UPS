using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class OtherChargesType: IOtherChargesType
	{
		public string MonetaryValue { get; set; }
		public string Description { get; set; }
	}
}
