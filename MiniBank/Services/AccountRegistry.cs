using MiniBank.Interfaces;
using MiniBank.Model;

namespace MiniBank.Services
{
    public class AccountRegistry
    {
        public List<BankAccount> Accounts { get; set; }
        public void ListAccounts()
        {
            Console.WriteLine("Listing accounts");
        }

        public void CreateAccount()
        {
            Console.WriteLine("Creating account...");
        }
    }
}
