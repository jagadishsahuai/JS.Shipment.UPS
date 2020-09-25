using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class HandlingUnitsType : IHandlingUnitsType
	{
		public string Quantity { get; set; }
		public ShipUnitOfMeasurementType Type { get; set; }
		public HandlingUnitsDimensionsType Dimensions { get; set; }
	}
}
