using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IShipperAccountType
    {
        string AccountNumber { get; set; }
        string AccountCountryCode { get; set; }
    }
}
