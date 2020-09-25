using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PackageAssociatedType: IPackageAssociatedType
	{
		public string packageNumber { get; set; }
		public string productAmount { get; set; }
	}
}
