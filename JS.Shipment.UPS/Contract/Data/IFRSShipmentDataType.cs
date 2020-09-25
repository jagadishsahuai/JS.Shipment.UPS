using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IFRSShipmentDataType
    {
        TransportationChargeType TransportationCharges { get; set; }
        FreightDensityRateType FreightDensityRate { get; set; }
        HandlingUnitsResponseType[] HandlingUnits { get; set; }
    }
}
