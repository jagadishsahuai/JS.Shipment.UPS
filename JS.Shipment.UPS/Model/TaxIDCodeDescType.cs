using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class TaxIDCodeDescType : ITaxIDCodeDescType
	{
		public string Code { get ; set; }
		public string Description { get; set; }
	}
}
