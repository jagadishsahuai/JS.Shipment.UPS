using System.Threading.Tasks;
using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Contract.Service
{
    public interface IPickupService
    {
        Task<INativePickupCreationResponse> ProcessPickupCreationAsync(IPickupCreationRequest request, IUPSConfiguration configuration = null);
        Task<INativePickupCancelResponse> ProcessPickupCancelAsync(IPickupCancelRequest request, IUPSConfiguration configuration = null);
        Task<INativePickupGetServiceCenterFacilitiesResponse> ProcessPickupGetServiceCenterFacilitiesAsync(IPickupGetServiceCenterFacilitiesRequest request, IUPSConfiguration configuration = null);
        Task<INativePickupPendingStatusResponse> ProcessPickupPendingStatusAsync(IPickupPendingStatusRequest request, IUPSConfiguration configuration = null);
        Task<INativePickupRateResponse> ProcessPickupRateAsync(IPickupRateRequest request, IUPSConfiguration configuration = null);
        Task<INativePickupGetPoliticalDivision1ListResponse> ProcessPickupGetPoliticalDivision1ListAsync(IPickupGetPoliticalDivision1ListRequest request, IUPSConfiguration configuration = null);
    }
}
