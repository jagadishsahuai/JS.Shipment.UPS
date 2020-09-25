using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipFromRequestType: IShipFromRequestType
	{
		public AddressRequestType Address { get; set; }
	}
}
