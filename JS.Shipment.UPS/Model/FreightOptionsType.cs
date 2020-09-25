using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class FreightOptionsType: IFreightOptionsType
    {
        public ShipmentServiceOptionsType ShipmentServiceOptions { get; set; }
        public string OriginServiceCenterCode { get; set; }
        public string OriginServiceCountryCode { get; set; }
        public DestinationAddressType DestinationAddress { get; set; }
        public ShipmentDetailType ShipmentDetail { get; set; }
    }
}