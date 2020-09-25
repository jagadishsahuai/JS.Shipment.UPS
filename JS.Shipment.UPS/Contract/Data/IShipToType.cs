using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipToType: ICompanyInfoType
    {
		string FaxNumber { get; set; }
		string EMailAddress { get; set; }
		ShipToAddressType Address { get; set; }
		string LocationID { get; set; }
	}
}
