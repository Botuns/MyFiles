using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_BOTUNS_BANKING_APP
{
    class DashBoard
    {
        public void Dashboard()
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
            // AccountHolder accountHolders = new AccountHolder();

            switch (option)
            {
                case 1:
                    AcccountManager.RegisterAccountHolder();
                    Dashboard();
                    break;
                //case 2:
                //    AccountHolder.Deposit();
                //    Dashboard();
                //    break;
                //case 3:
                //    AccountHolder.Withdraw();
                //    Dashboard();
                //    break;
                //case 4:
                //    AccountHolder.Transfer();
                //    Dashboard();
                //    break;
            }
        }

    }
}
