using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FRSShipmentDataType: IFRSShipmentDataType
    {
        public TransportationChargeType TransportationCharges { get; set; }
        public FreightDensityRateType FreightDensityRate { get; set; }
        public HandlingUnitsResponseType[] HandlingUnits { get; set; }
    }
}