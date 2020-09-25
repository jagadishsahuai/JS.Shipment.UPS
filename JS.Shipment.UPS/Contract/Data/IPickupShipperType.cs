using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IPickupShipperType
    {
        AccountType Account { get; set; }
        ChargeCardType ChargeCard { get; set; }
        TaxInformationType TaxInformation { get; set; }
    }
}
