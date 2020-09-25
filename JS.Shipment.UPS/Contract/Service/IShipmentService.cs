using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using System.Threading.Tasks;

namespace JS.Shipment.UPS.Contract.Service
{
    public interface IShipmentService
    {
        Task<INativeShipmentResponse> ProcessShipmentAsync(IShipmentRequest request, IUPSConfiguration configuration = null);
        Task<INativeShipConfirmResponse> ProcessShipConfirmAsync(IShipConfirmRequest request, IUPSConfiguration configuration = null);
        Task<INativeShipAcceptResponse> ProcessShipAcceptAsync(IShipAcceptRequest request, IUPSConfiguration configuration = null);
    }
}
