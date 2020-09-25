using JS.Shipment.UPS.Contract.Configuration;
using JS.Shipment.UPS.Contract.Data;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JS.Shipment.UPS.Contract.Service
{
    public interface ILabelRecoveryService
    {
        Task<INativeLabelRecoveryResponse> ProcessLabelRecoveryAsync(ILabelRecoveryRequest request, IUPSConfiguration configuration = null);
    }
}
