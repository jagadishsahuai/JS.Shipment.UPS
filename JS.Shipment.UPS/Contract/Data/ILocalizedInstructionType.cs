namespace JS.Shipment.UPS.Contract.Data
{
    public interface ILocalizedInstructionType
    {
        string Locale { get; set; }
        string Last50ftInstruction { get; set; }
    }
}
