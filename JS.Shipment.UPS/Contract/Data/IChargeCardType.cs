using JS.Shipment.UPS.Model;

namespace JS.Shipment.UPS.Contract.Data
{
    public interface IChargeCardType
    {
        string CardHolderName { get; set; }
        string CardType { get; set; }
        string CardNumber { get; set; }
        string ExpirationDate { get; set; }
        string SecurityCode { get; set; }
        ChargeCardAddressType CardAddress { get; set; }
    }
}
