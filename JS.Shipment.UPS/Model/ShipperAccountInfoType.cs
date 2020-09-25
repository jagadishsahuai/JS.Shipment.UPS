using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipperAccountInfoType: IShipperAccountInfoType
	{
		public string PostalCode { get; set; }
		public string CountryCode { get; set; }
	}
}
