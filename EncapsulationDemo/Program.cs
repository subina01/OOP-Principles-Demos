namespace EncapsulationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount("Subina", 5000);

            account.Deposit(2000);
            account.Withdraw(3000);
            account.GetBalance();
           // account.Balance = 1000;
            account.Withdraw(6000);
            account.Deposit(-500);
        }
    }
}