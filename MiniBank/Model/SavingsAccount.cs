using MiniBank.Interfaces;

namespace MiniBank.Model
{
    public class SavingsAccount : BankAccount, IInterestBearing
    {
        public void ApplyMonthlyInterest()
        {
            if(Balance > 0)
            {
                Balance += Balance * 0.02m;
            }
        }
    }
}
