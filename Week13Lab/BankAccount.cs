using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week13Lab
{
    class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
        public void CalculateInterest() { }

    }
}
