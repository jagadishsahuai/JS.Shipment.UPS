﻿using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class AccountType: IAccountType
    {
        public string AccountNumber { get; set; }
        public string AccountCountryCode { get; set; }
    }
}
