using JS.Shipment.UPS.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupAddressType
    {
        string CompanyName { get; set; }
        string ContactName { get; set; }
        string[] AddressLine { get; set; }
        string Room { get; set; }
        string Floor { get; set; }
        string City { get; set; }
        string StateProvince { get; set; }
        string Urbanization { get; set; }
        string PostalCode { get; set; }
        string CountryCode { get; set; }
        string ResidentialIndicator { get; set; }
        string PickupPoint { get; set; }
        PhoneType Phone { get; set; }
    }
}
