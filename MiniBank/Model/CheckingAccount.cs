using MiniBank.Interfaces;

namespace MiniBank.Model
{
    public class CheckingAccount : BankAccount, IOverdraftPolicy
    {
        public decimal OverdraftLimit { get; } = -200;

        public override bool Withdraw(decimal amount, out string? error)
        {
            if(amount <= 0)
            {
                error = "Amount must be greater than zero.";
                return false;
            }

            if(Balance - amount < OverdraftLimit)
            {
                error = "Withdrawal would exceed overdraft limit.";
                return false;
            }

            Balance -= amount;
            error = null;
            return true;
        }
    }
}
