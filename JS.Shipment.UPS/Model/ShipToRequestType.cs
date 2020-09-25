using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipToRequestType: IShipToRequestType
	{
		public AddressRequestType Address { get; set; }
	}
}
