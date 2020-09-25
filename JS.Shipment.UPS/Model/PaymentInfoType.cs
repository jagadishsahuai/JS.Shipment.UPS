using JS.Shipment.UPS.Contract.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Model
{
	public class PaymentInfoType : IPaymentInfoType
	{
		public ShipmentChargeType[] ShipmentCharge { get; set; }
		public string SplitDutyVATIndicator { get; set; }
	}
}
