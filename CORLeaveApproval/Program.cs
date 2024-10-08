namespace CORLeaveApproval
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            ApprovalBase Prossesing = new TeamLeader();
            ApprovalBase HumanResources = new HR();
            ApprovalBase manager = new Managers();


            Prossesing.SetSuccessor(HumanResources);
            HumanResources.SetSuccessor(manager);

            string? Result;
        }

        public abstract class ApprovalBase
        {
            protected ApprovalBase _successor;
            
            public abstract void Leave(int Days, string? result);


        }
    }
}