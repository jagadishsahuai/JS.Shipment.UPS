using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IContactInfoType
	{
		string Name { get; set; }
		ShipPhoneType Phone { get; set; }
	}
}
