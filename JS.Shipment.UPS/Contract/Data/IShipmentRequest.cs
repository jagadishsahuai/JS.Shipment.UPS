using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipmentRequest: IShipRequest
    {		
		ReceiptSpecificationType ReceiptSpecification { get; set; }
	}
}
