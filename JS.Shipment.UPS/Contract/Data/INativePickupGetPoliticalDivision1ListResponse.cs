using JS.Shipment.UPS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface INativePickupGetPoliticalDivision1ListResponse
    {
        [AutoMapper.IgnoreMap]
        bool IsSuccessful { get; }
        PickupGetPoliticalDivision1ListResponse PickupGetPoliticalDivision1ListResponse { get; set; }
    }
}
