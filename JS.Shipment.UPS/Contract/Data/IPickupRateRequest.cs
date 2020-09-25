using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupRateRequest
    {
        RequestType Request { get; set; }
        ShipperAccountType ShipperAccount { get; set; }
        PickupRateAddressType PickupAddress { get; set; }
        string AlternateAddressIndicator { get; set; }
        string ServiceDateOption { get; set; }
        PickupDateInfoType PickupDateInfo { get; set; }
        string TaxInformationIndicator { get; set; }
        string UserLevelDiscountIndicator { get; set; }
    }
}
