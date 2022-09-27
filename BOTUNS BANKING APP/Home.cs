using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTUNS_BANKING_APP
{
    public class Home
    {
        public void Homepage()
        {
            Console.WriteLine("-_-_-_-_WELCOME TO BOTUNS BANKING APP-_-_-_-_");
            Console.WriteLine("Choose an option from the menu to perform an action");
            Console.WriteLine("1. Register");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Transfer");
            Console.WriteLine("5. Change Pin");
            Console.WriteLine("6. Update Profile");
            Console.WriteLine("7. Exit");

            int option = int.Parse(Console.ReadLine());
            AccountHolder accountHolders = new AccountHolder();

            switch (option)
            {
                case 1:
                    AccountHolder.Register();
                    Homepage();
                    break;
                case 2:
                    AccountHolder.Deposit();
                    Homepage();
                    break;
                case 3:
                    AccountHolder.Withdraw();
                    Homepage();
                    break;
                case 4:
                    AccountHolder.Transfer();
                    Homepage();
                    break;
            }
        }
    }
}
