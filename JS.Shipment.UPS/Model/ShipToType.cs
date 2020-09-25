using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ShipToType : CompanyInfoType, IShipToType
	{
		public string FaxNumber { get; set; }
		public string EMailAddress { get; set; }
		public ShipToAddressType Address { get; set; }
		public string LocationID { get; set; }
	}
}
