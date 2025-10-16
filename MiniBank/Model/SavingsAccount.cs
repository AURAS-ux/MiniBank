using MiniBank.Interfaces;

namespace MiniBank.Model
{
    public class SavingsAccount : BankAccount, IInterestBearing
    {
        public SavingsAccount(string owner, decimal balance) : base(owner, balance)
        {
        }
        public void ApplyMonthlyInterest()
        {
            if(Balance > 0)
            {
                Balance += Balance * Constants.savingsInterestRate;
            }
        }
    }
}
