using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Criteria;
using JS.Shipment.UPS.Contract.Data;
using System.Threading.Tasks;

namespace JS.Shipment.UPS.Contract.Service
{
    public interface ITrackService
    {
        Task<INativeTrackResponse> ProcessTrackAsync(ITrackRequest request, IUPSConfiguration configuration = null);
        Task<INativeTrackResponse> ProcessTrackAsync(ITrackCriteria criteria, IUPSConfiguration configuration = null);
    }
}
