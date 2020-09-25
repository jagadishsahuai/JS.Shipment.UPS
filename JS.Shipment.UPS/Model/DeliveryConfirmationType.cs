using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DeliveryConfirmationType: IDeliveryConfirmationType
	{
		public string DCISType { get; set; }
		public string DCISNumber { get; set; }
	}
}
