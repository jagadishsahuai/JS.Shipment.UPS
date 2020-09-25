using JS.Shipment.UPS.Contract.Configuration;

namespace JS.Shipment.UPS.Configuration
{
    public class Authentication: IAuthentication
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string AccountNumber { get; set; }
		public string AccessKey { get; set; }
        public string CustomerContext { get; set; }
    }
}
