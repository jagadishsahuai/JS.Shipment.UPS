using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PromotionalDiscountInformationType : IPromotionalDiscountInformationType
	{
		public string PromoCode { get; set; }
		public string PromoAliasCode { get; set; }
	}
}
