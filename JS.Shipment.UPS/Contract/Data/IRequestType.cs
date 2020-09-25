using JS.Shipment.UPS.Model;
namespace JS.Shipment.UPS.Contract.Data
{
    public interface IRequestType
	{
		string[] RequestOption { get; set; }
		string SubVersion { get; set; }
		TransactionReferenceType TransactionReference { get; set; }
	}
}
