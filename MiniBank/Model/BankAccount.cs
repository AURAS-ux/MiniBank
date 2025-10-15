using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBank.Model
{
    public class BankAccount
    {
        public int Id { get; set; }
        public string Owner { get; set; }
        public decimal Balance { get; set; }
    }
}
