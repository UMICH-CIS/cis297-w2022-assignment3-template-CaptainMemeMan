using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApplication
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.Clear();
            decimal[] MoneyArray = new decimal[2] {500m , 300m};
            SavingAccount accountsaving1 = new SavingAccount(MoneyArray[0], 0.5m);
            CheckingAccount checkaccount2 = new CheckingAccount(MoneyArray[1], 3m);
            
            Console.WriteLine("Which account are you? (Saving = 1 or Checking = 2) (10 = Exit Program)");
            int numberperson = int.Parse(Console.ReadLine());
            Console.Clear();

            if (numberperson == 1)
            {
                Console.WriteLine("Login into Account 1");

                Console.WriteLine("The Current Balance of your Saving Account is : ${0}", accountsaving1.Balances);
                
                Console.WriteLine("Enter how much account you want to withdraw from your account ");
                decimal mun = decimal.Parse(Console.ReadLine());
                accountsaving1.Debt(mun);
                if (mun > accountsaving1.Balances)
                {
                    Console.WriteLine("Balance is still: ${0}", accountsaving1.Balances);
                }else Console.WriteLine("New Balance is : ${0}", accountsaving1.Balances);
                

                Console.Write("Press Enter to return to Exit the Program.");
                Console.ReadLine();
            }
            else if (numberperson == 10)
            {
                Console.Clear(); 
            }





        }

    }
}
