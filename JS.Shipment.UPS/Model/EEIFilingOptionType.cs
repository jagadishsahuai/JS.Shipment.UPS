using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class EEIFilingOptionType: IEEIFilingOptionType
	{
		public string Code { get; set; }
		public string EMailAddress { get; set; }
		public string Description { get; set; }
		public UPSFiledType UPSFiled { get; set; }
		public ShipperFiledType ShipperFiled { get; set; }
	}
}
