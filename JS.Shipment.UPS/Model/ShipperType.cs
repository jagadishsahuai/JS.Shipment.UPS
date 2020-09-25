using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipperType : CompanyInfoType, IShipperType
	{
		public string ShipperNumber { get; set; }
		public string FaxNumber { get; set; }
		public string EMailAddress { get; set; }
		public ShipAddressType Address { get; set; }
	}
}
