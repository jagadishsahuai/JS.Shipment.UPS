using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IEEIFilingOptionType
	{
		string Code { get; set; }
		string EMailAddress { get; set; }
		string Description { get; set; }
		UPSFiledType UPSFiled { get; set; }
		ShipperFiledType ShipperFiled { get; set; }
	}
}
