using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    public class Account
    {
        private decimal balance;
        public decimal money; 
        public Account()
        {
            balance = money;
        }
        public decimal Balances{ get { return balance; }
            set{
                if (value < 0)
                {
                    balance = 0;
                    Console.WriteLine("Not enough funds.");
                    
                }
                else
                    balance = value;
               
            }
        }

        public virtual void Credit(decimal money)
        {
            balance = balance + money;
        }
        public virtual bool Debt(decimal money)
        {
            if (balance < money)
            {
                Console.WriteLine("Debt amount exceeded account balance.");
                return false;
            }
            else
                balance = balance - money;
                return true; 
        }
    }

   
        
}

