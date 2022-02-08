using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class SavingAccount : Account
    {
        private decimal IntrestRate;
         
        public SavingAccount(decimal money, decimal Intrest): base(money)
        {
            IntrestRate = Intrest;
            Balances = money; 
              
        }

        public decimal CalcIntrestRate()
        {
            return Balances * IntrestRate; 
        }
    }
}
