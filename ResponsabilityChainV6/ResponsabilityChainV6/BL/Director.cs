namespace ResponsabilityChainV6.BL
{
    public class Director : Approver
    {
        public Director()
        {
            authorizationLimit = 10000;
        }
    }
}