using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipperType: ICompanyInfoType
    {
		string ShipperNumber { get; set; }
		string FaxNumber { get; set; }
		string EMailAddress { get; set; }
		ShipAddressType Address { get; set; }
	}
}
