using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class PalletInformationType: IPalletInformationType
    {
        public DimensionsType Dimensions { get; set; }
    }
}