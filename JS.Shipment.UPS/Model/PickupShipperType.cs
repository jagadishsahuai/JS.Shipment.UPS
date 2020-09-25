using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PickupShipperType: IPickupShipperType
    {
        public AccountType Account { get; set; }
        public ChargeCardType ChargeCard { get; set; }
        public TaxInformationType TaxInformation { get; set; }
    }
}
