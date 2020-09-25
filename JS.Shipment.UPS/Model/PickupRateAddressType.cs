using JS.Shipment.UPS.Contract.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Model
{
    public class PickupRateAddressType: IPickupRateAddressType
    {
        public string[] AddressLine { get; set; }
        public string City { get; set; }
        public string StateProvince { get; set; }
        public string PostalCode { get; set; }
        public string CountryCode { get; set; }
        public string ResidentialIndicator { get; set; }
    }
}
