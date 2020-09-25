using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipFromType : CompanyInfoType, IShipFromType
	{
		public string FaxNumber { get; set; }
		public ShipAddressType Address { get; set; }
		public string EMailAddress { get; set; }
	}
}
