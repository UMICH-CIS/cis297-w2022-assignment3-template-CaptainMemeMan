using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class CheckingAccount: Account
    {
        private decimal fee;
        CheckingAccount(decimal del, decimal setfee)
        {
            Balances = del;
            fee = setfee; 
        }
        public override void Credit(decimal money)
        {
            Balances = Balances + money;
            Balances = Balances - fee; 
        }
        public override bool Debt(decimal money)
        {
            if (Balances < money)
            {
                Console.WriteLine("Debt amount exceeded account balance.");
                return false;
            }
            else
                Balances = Balances - money;
                Balances = Balances - fee; 
            return true;
        }
    }
}

