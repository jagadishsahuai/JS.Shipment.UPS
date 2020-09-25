using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipFromType
	{
		string FaxNumber { get; set; }
		ShipAddressType Address { get; set; }
		string EMailAddress { get; set; }
	}
}
