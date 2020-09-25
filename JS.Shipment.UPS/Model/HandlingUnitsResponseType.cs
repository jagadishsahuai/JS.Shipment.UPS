using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class HandlingUnitsResponseType: IHandlingUnitsResponseType
    {
        public string Quantity { get; set; }
        public ShipUnitOfMeasurementType Type { get; set; }
        public HandlingUnitsDimensionsType Dimensions { get; set; }
        public AdjustedHeightType AdjustedHeight { get; set; }
    }
}