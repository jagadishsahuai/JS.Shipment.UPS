using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class DGSignatoryInfoType : IDGSignatoryInfoType
	{
		public string Name { get; set; }
		public string Title { get; set; }
		public string place { get; set; }
		public string Date { get; set; }
		public string ShipperDeclaration { get; set; }
		public string UploadOnlyIndicator { get; set; }
	}
}
