using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationDemo
{
    public class BankAccount
    {
        private string? AccountHolderName;//Encapsulation
        private decimal Balance;//Encapsulation

        public BankAccount(string? AccountHolderName, decimal Balance)
        {
            this.AccountHolderName = AccountHolderName;
            if (Balance < 0)
            {
                try
                {
                    throw new ArgumentException("Deposite cannot be Negative");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}");
                }
            }
            this.Balance = Balance;
        }

        public string accountHolderName//adding readonly public property
        {
            get
            {
                return AccountHolderName;
            }
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0)
            {
                try
                {
                    throw new ArgumentException("Please Enter the Valid Amount");
                }
                catch( Exception ex)
                {
                    Console.WriteLine($"{ex}");
                }
            }

            Balance += amount;
            Console.WriteLine($"amount = {amount} is deposited in your account");
        }

        public void Withdraw( decimal amount)
        {
            if (amount < 0)
            {
                try
                {
                    throw new ArgumentException("Please Enter the Valid Amount");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{ex}");
                }
            }
            else if (amount > Balance) 
            {
                Console.WriteLine("You can only withdraw with in the range you have in your account");
            }
            else
            {
                Balance -= amount;
                Console.WriteLine($"{amount} has been withdrawn from your account");
            }
        }

        public void GetBalance()
        {
            Console.WriteLine($"{Balance} is your Balance in your bank  account");
        }
    
    }
}
