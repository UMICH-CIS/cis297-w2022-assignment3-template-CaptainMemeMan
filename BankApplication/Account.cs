using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// The Account class is the parent class of the SavingAccount and CheckingAccount. 
    /// It holds the variable balance and methods of credit and debit, which will be used throughout the rest of the other child classes 
    /// </summary>
    public class Account
    {
        private decimal balance; //stores balance as a decimal variable 
        
        public Account(decimal money) //constructor in order to put money into the account 
        {
            balance = money;
        }
        public decimal Balances{ get { return balance; } //set and gets in order to access the private balance variable 
            set{ //set has more boundries in order to prevent it going from a negative value 
                if (value < 0)
                {
                    balance = 0;
                    Console.WriteLine("Not enough funds.");
                    
                }
                else
                    balance = value;
               
            }
        }

        public virtual void Credit(decimal money)//Credit method is virtual in order to change it in other accounts and this adds money to the account 
        {
            balance = balance + money;
        }
        public virtual bool Debit(decimal money) //Debit method is virtual in order to change it in other accounts and this removes money from the account 
        {
            if (balance < money)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
                balance = balance - money;
                return true; 
        }
    }

   
        
}

