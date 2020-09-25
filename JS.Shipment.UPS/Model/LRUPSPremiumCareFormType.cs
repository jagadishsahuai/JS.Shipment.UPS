using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LRUPSPremiumCareFormType: ILRUPSPremiumCareFormType
    {
        public string PageSize { get; set; }
        public string PrintType { get; set; }
    }
}