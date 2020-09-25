using JS.Shipment.UPS.Contract.Data;

namespace JS.Shipment.UPS.Model
{
    public class LocalizedInstructionType: ILocalizedInstructionType
    {
        public string Locale { get; set; }
        public string Last50ftInstruction { get; set; }
    }
}