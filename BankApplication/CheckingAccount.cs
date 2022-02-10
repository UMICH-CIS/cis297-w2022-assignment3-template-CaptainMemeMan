using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// This class is a child and inhrients from the Account class. 
    /// The CheckingAccount class has a private varible that will has the fee, which will subtract the fee for every time you use the bank account  
    /// This class has modified methods of Credit and Debit in order to subtract the fee from the total money you have for everytime you use this class 
    /// </summary>
    class CheckingAccount : Account
    {
        private decimal fee; //private variable that would access the fee
       public CheckingAccount(decimal money, decimal setfee): base(money) //constructor that sets the money and the fee for the CheckingAccount 
        {
            Balances = money;
            fee = setfee; 
        }
        public override void Credit(decimal money) //overrides the Credit method from Account & subtracts fee 
        {
            Balances = Balances + money;
            Balances = Balances - fee; 
        }
        public override bool Debit(decimal money) //overrides the Debit method from Account & substracts fee 
        {
            if (Balances < money)
            {
                Console.WriteLine("Debit amount exceeded account balance.");
                return false;
            }
            else
                Balances = Balances - money;
                Balances = Balances - fee; 
            return true;
        }
    }
}

