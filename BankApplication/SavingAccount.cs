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
         
        public SavingAccount(decimal bal, decimal Intrest)
        {
            IntrestRate = Intrest;
            Balances = bal; 
              
        }

        public decimal CalcIntrestRate()
        {
            return Balances * IntrestRate; 
        }
    }
}
