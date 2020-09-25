using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using System.Threading.Tasks;

namespace JS.Shipment.UPS.Contract.Service
{
    public interface IVoidShipmentService
    {
        Task<INativeVoidShipmentResponse> ProcessVoidAsync(IVoidShipmentRequest request, IUPSConfiguration configuration = null);
    }
}
