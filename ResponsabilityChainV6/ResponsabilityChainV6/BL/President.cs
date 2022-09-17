namespace ResponsabilityChainV6.BL
{
    public class President : Approver
    {
        public President()
        {
            authorizationLimit = 100000;
        }

        public override void ProcessRequest(PurchaseOrder order)
        {
            if (order.Amount < authorizationLimit)
            {
                Console.WriteLine($"{this.GetType().Name} approved the request #{order.Number} for: {order.Purpose}");
                return;
            }

            Console.WriteLine($"Request #{order.Number} requires an executive meeting as the requested amount is too high");
        }
    }
}