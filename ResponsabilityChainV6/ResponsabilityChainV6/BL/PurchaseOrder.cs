namespace ResponsabilityChainV6.BL
{
    public class PurchaseOrder
    {
        public int Number { get; private set; } = 0;
        public double Amount { get; private set; } = 0;
        public string Purpose { get; private set; } = "";

        public PurchaseOrder(int number, double amount, string purpose)
        {
            Number = number;
            Amount = amount;
            Purpose = purpose;
        }
    }
}