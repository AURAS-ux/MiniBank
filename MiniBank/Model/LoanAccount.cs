using MiniBank.Interfaces;

namespace MiniBank.Model
{
    public class LoanAccount : BankAccount, IInterestBearing
    {
        public void ApplyMonthlyInterest()
        {
            if(Balance < 0)
            {
                Balance += Balance * Constants.loanInterestRate;
            }
        }

        public override bool Withdraw(decimal amount, out string? error)
        {
            if(amount <= 0)
            {
                error = "Amount must be greater than zero.";
                return false;
            }

            Balance -= amount;
            error = null;
            return true;
        }
    }
}
