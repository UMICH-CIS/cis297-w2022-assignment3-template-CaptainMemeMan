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
                Console.WriteLine("Login into Saving Account 1");

                Console.WriteLine("The Current Balance of your Saving Account is : ${0}", accountsaving1.Balances);
                Console.WriteLine("Would you like to withdraw, transfer, or add your interest rate to your money into your Saving Account? (1 = Withdraw or 2 = Transfer or 3 = Transfer Intrest Rate)");
                int withortran = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (withortran)
                {
                    case 1:
                        Console.WriteLine("The Current Balance of your Saving Account is : ${0}", accountsaving1.Balances);
                        Console.WriteLine("Enter how much money you want to withdraw from your account ");
                        decimal mun = decimal.Parse(Console.ReadLine());
                        accountsaving1.Debt(mun);
                        if (mun > accountsaving1.Balances)
                        {
                            Console.WriteLine("Balance is still: ${0}", accountsaving1.Balances);
                        }
                        else Console.WriteLine("New Balance is : ${0}", accountsaving1.Balances);
                        break;
                    case 2:
                        Console.WriteLine("The Current Balance of your Saving Account is : ${0}", accountsaving1.Balances);
                        Console.WriteLine("Enter how much money you want to transfer to your account ");
                        decimal mun2 = decimal.Parse(Console.ReadLine());
                        accountsaving1.Credit(mun2);
                        Console.WriteLine("New Balance is: ${0}", accountsaving1.Balances);
                        break;
                    case 3:
                        Console.WriteLine("The Current Balance of your Saving Account is : ${0}", accountsaving1.Balances);
                        Console.WriteLine("Your intrest of your total savings would be: ${0}", accountsaving1.CalcIntrestRate());
                        decimal interest = accountsaving1.CalcIntrestRate();
                        accountsaving1.Credit(interest);
                        Console.WriteLine("Interest plus your Current Balance would be: ${0}", accountsaving1.Balances);
                        break;

                }




                Console.Write("Press Enter to return to Exit the Program.");
                Console.ReadLine();
            }
            else if (numberperson == 2)
            {
                Console.WriteLine("Login into Checking Account 1");

                Console.WriteLine("The Current Balance of your Checking Account is : ${0}", checkaccount2.Balances);
                Console.WriteLine("Would you like to withdraw or transfer money into your checking account? Each transaction will have a $3 fee. (1 = Withdraw or 2 = Transfer) ");
                int withortran2 = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (withortran2)
                {
                    case 1:
                        Console.WriteLine("The Current Balance of your Checking Account is : ${0}", checkaccount2.Balances);
                        Console.WriteLine("Enter how much money you want to withdraw from your account ");
                        decimal mun2 = decimal.Parse(Console.ReadLine());
                        checkaccount2.Debt(mun2);
                        if (mun2 > checkaccount2.Balances)
                        {
                            Console.WriteLine("Balance is still: ${0}", checkaccount2.Balances);
                        }
                        else Console.WriteLine("New Balance is : ${0}", checkaccount2.Balances);
                        break;
                    case 2:
                        Console.WriteLine("The Current Balance of your Checking Account is : ${0}", checkaccount2.Balances);
                        Console.WriteLine("Enter how much money you want to transfer to your account ");
                        decimal num = decimal.Parse(Console.ReadLine());
                        checkaccount2.Credit(num);
                        Console.WriteLine("New Balance is: ${0}", checkaccount2.Balances);
                        break;
                   

                }




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
