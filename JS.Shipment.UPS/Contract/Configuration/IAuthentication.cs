namespace JS.Shipment.UPS.Contract.Configuration
{
    public interface IAuthentication
    {
        string UserName { get; set; }
        string Password { get; set; }
        string AccountNumber { get; set; }
        string AccessKey { get; set; }
        string CustomerContext { get; set; }
    }
}
