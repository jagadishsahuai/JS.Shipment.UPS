using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class ContactInfoType: IContactInfoType
	{
		public string Name { get; set; }
		public ShipPhoneType Phone { get; set; }
	}
}
