using MiniBank.Interfaces;
using MiniBank.Model;

namespace MiniBank.Services
{
    public class AccountRegistry
    {
        public List<BankAccount> Accounts { get; set; } = new List<BankAccount>();
        public void  ListAccounts()
        {
            Console.WriteLine("=========== Listing accounts ===========");
            foreach (var account in Accounts)
            {
                Console.WriteLine($"Account nr:{account.Id} of owner: {account.Owner} with balance: {account.Balance}");
            }
            Console.WriteLine("=========== Finished listing accounts ===========");
        }

        public void CreateAccount()
        {
            Console.WriteLine("===== Creating account =====");
            while (true)
            {
                Console.Write("Specify account type(Checking, Savings, Loan):");
                string accountType = Console.ReadLine();
                if (accountType == null || accountType == string.Empty)
                {
                    Console.WriteLine("Account type is required. Please specify account type(Checking, Savings, Loan):");
                    continue;
                }

                Console.Write("Who will own this account?:");
                string owner = Console.ReadLine();

                if (owner == null || owner == string.Empty)
                {
                    Console.WriteLine("Owner is required. Please specify who will own this account:");
                    continue;
                }

                Console.Write("What is the initial deposit amount?:");
                if (!decimal.TryParse(Console.ReadLine(), out decimal initialDeposit))
                {
                    Console.WriteLine("Initial deposit amount is required. Please specify the initial deposit amount:");
                    continue;
                }

                switch(accountType.ToLower())
                {
                    case "checking":
                        Accounts.Add(new CheckingAccount() { Owner = owner,Balance = initialDeposit});
                        break;
                    case "savings":
                        Accounts.Add(new SavingsAccount() { Owner = owner,Balance = initialDeposit});
                        break;
                    case "loan":
                        Accounts.Add(new LoanAccount() { Owner = owner, Balance = initialDeposit });
                        break;
                    default:
                        Console.WriteLine("Invalid account type. Please specify account type(Checking, Savings, Loan):");
                        continue;
                }

                Console.WriteLine("===== Account creation finished =====");
                break;
            }
        }
    }
}
