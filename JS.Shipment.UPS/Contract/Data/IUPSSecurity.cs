using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IUPSSecurity
	{
		UPSSecurityUsernameToken UsernameToken { get; set; }
		UPSSecurityServiceAccessToken ServiceAccessToken { get; set; }
	}
}
