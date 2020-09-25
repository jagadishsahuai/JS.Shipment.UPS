using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativePickupCreationResponse : IResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        [AutoMapper.IgnoreMap]
        string PickupConfirmationNumber { get; }
        [AutoMapper.IgnoreMap]
        StatusCodeDescriptionType RateStatus { get; }
        [AutoMapper.IgnoreMap]
        RateResultType RateResult { get; }
        [AutoMapper.IgnoreMap]
        ChargeDetailType[] ChargeDetails { get; }
        PickupCreationResponse PickupCreationResponse { get; set; }
    }
}
