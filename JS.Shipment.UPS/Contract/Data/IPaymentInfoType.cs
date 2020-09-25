using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPaymentInfoType
	{
		ShipmentChargeType[] ShipmentCharge { get; set; }
		string SplitDutyVATIndicator { get; set; }
	}
}
