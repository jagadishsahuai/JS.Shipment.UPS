using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupRateAddressType
    {
        string[] AddressLine { get; set; }
        string City { get; set; }
        string StateProvince { get; set; }
        string PostalCode { get; set; }
        string CountryCode { get; set; }
        string ResidentialIndicator { get; set; }
    }
}
