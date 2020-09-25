using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class RedirectType: IRedirectType
    {
        public string CompanyName { get; set; }
        public string LocationID { get; set; }
        public string PickupDate { get; set; }
    }
}