using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    /// <summary>
    /// This class is a child and inhrients from the Account class. 
    /// The SavingAccount class has a private varible that will has the interestrate, which is how much money is earned as time goes on in an actual bank. 
    /// This class has a method that calculates the actual interest rate in order to add onto the balances. 
    /// </summary>
    public class SavingAccount : Account
    {
        private decimal IntrestRate; //private decimal that adds 
         
        public SavingAccount(decimal money, decimal Intrest): base(money) //contructor in order to set balances and the interest rate 
        {
            IntrestRate = Intrest;
            Balances = money; 
              
        }

        public decimal CalcIntrestRate() //calculates the interest rate by multiplying Balances and the InterestRate given 
        {
            return Balances * IntrestRate; 
        }
    }
}
