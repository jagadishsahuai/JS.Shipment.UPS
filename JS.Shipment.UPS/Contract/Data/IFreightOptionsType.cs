using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IFreightOptionsType
    {
        ShipmentServiceOptionsType ShipmentServiceOptions { get; set; }
        string OriginServiceCenterCode { get; set; }
        string OriginServiceCountryCode { get; set; }
        DestinationAddressType DestinationAddress { get; set; }
        ShipmentDetailType ShipmentDetail { get; set; }
    }
}
