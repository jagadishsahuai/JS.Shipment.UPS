using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipToAddressType : ShipAddressType, IShipToAddressType
	{
		public string ResidentialAddressIndicator { get ; set; }
	}
}
