using System.Net;

namespace ResponsabilityChainV6.BL
{
    public abstract class Approver
    {
        protected Approver? successor;
        protected double authorizationLimit = 0;

        public void SetSuccessor(Approver succesor)
        {
            this.successor = succesor;
        }

        public virtual void ProcessRequest(PurchaseOrder order) 
        {
            if (order.Amount < authorizationLimit)
            {
                Console.WriteLine($"{this.GetType().Name} approved the request #{order.Number} for: {order.Purpose}");
                return;
            }

            if (successor != null)
            {
                successor.ProcessRequest(order);
            }
        }
    }
}