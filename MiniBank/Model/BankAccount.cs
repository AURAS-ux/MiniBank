using MiniBank.Interfaces;

namespace MiniBank.Model
{
    public class BankAccount : ITransactable, IStatement
    {
        public int Id { get; set; }
        public string Owner { get; set; } = string.Empty;
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void PrintStatement()
        {
            Console.WriteLine(this.ToString());
        }

        public virtual bool Withdraw(decimal amount, out string? error)
        {
            if (amount <= 0)
            {
                error = "Amount must be greater than zero.";
                return false;
            }

            if (amount > Balance)
            {
                error = "Insufficient funds.";
                return false;
            }

            Balance -= amount;
            error = null;
            return true;
        }

        public override string ToString()
        {
            return $"Owner: {Owner} - {Id}\n Balance:{Balance}";
        }
    }
}
