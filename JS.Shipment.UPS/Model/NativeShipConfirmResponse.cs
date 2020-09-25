
using JS.Shipment.UPS.Constant;
using JS.Shipment.UPS.Contract.Data;
using System.Linq;

namespace JS.Shipment.UPS.Model
{
    public class NativeShipConfirmResponse : INativeShipConfirmResponse
    {
        [AutoMapper.IgnoreMap]
        public string Message { get; set; }
        [AutoMapper.IgnoreMap]
        public bool IsSuccessful
        {
            get
            {
                return AppConstants.BOOLEAN_TRUES.Contains(ShipConfirmResponse?.Response?.ResponseStatus?.Code);
            }
        }
        [AutoMapper.IgnoreMap]
        public string MasterTrackingReferenceNumber
        {
            get
            {
                return ShipConfirmResponse?.ShipmentResults?.ShipmentIdentificationNumber;
            }
        }
        [AutoMapper.IgnoreMap]
        public string ShipmentDigest
        {
            get
            {
                return ShipConfirmResponse?.ShipmentResults.ShipmentDigest;
            }
        }
        [AutoMapper.IgnoreMap]
        public ShipmentChargesType ShipmentCharges
        {
            get
            {
                return ShipConfirmResponse?.ShipmentResults?.ShipmentCharges;
            }
        }
        public ShipConfirmResponse ShipConfirmResponse { get; set; }
    }
}
