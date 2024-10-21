namespace static_constructors
{
    class SavingsAccount
    {
        public double currBalance;
        public static double currInterestRate;
        public SavingsAccount(double balance)
        {
            currBalance = balance;
        }
        // A static constructor! 
        static SavingsAccount()
        {
            Console.WriteLine("In static constructor!");
            currInterestRate = 0.04;
        }
    }
}
