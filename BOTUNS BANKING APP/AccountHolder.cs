using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOTUNS_BANKING_APP
{
    public class AccountHolder
    {
        private static string _firstName;
        private static string _lastName;
        private static int _epin;
        static AccountHolder[] accountHolders = new AccountHolder[100];
        public static int _acctNo;
        static int count = 0;
        //private static int epin;
        // private static  AccountHolder[] deposit = new AccountHolder[100];
        private static int _deposit = 0;
        


        public AccountHolder(string firstName, string lastName, int epin , int acctNo)
        {
            _firstName = firstName;
            _lastName = lastName;
            _epin = epin;
            _acctNo = acctNo;
        }

        public AccountHolder()
        {
        }

        public static int GetAcctNo()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            Random num = new Random();
            for (int i = 0000000000; i < 1000000000; i++)
            {
                _acctNo += num.Next(0000000000, 1000000000);
            }
            for (int y = 0; y < 9; y++)
            {
                int n = num.Next(0, 10);
                _acctNo += array[n];
            }
            Console.WriteLine($" Your reg no is {_acctNo}");
            return _acctNo;
        }
        public static void Withdraw()
        {
            Console.Write("Please enter your epin:  ");
            int epin = int.Parse(Console.ReadLine());
            if (epin == AccountHolder._epin)
            {
                Console.WriteLine("Enter Acct num");
                int acctNo = int.Parse(Console.ReadLine());
                if (acctNo == GetAcctNo())
                {
                    Console.WriteLine("Enter amount you want to withdraw");
                    int withdraw = int.Parse(Console.ReadLine());
                    int balance = (AccountHolder._deposit - withdraw);
                    for (int i =0; i < AccountHolder._deposit; i++)
                    {
                        AccountHolder._deposit = balance;
                    }
                    Console.WriteLine($"You have suceesfully withdrawn {withdraw} and your balance is {balance} ");




                }
            }
            else
            {
                Console.WriteLine("Invalid input pls: \n 1.Register if you have not done so.\n 2.Provide correct input ");
            }
            

        }
        public static void Transfer()
        {
            Console.Write("Please enter your epin:  ");
            int epin = int.Parse(Console.ReadLine());
            if (epin == AccountHolder._epin)
            {
                Console.WriteLine("Enter Acct num");
                int acctNo = int.Parse(Console.ReadLine());
                if (acctNo == GetAcctNo())
                {
                    Console.WriteLine("Enter amount you want to transfer");
                    int transfer = int.Parse(Console.ReadLine());
                    if(transfer < AccountHolder._deposit)
                    {
                        int transferred = (AccountHolder._deposit - transfer);

                        Console.WriteLine($"you have sucessfully transferred, your balance is {transferred}");
                    }
                    if(transfer > AccountHolder._deposit)
                    {
                        Console.WriteLine("sorry you have an insufficient balance.");
                    }


                }
            }
            else
            {
                Console.WriteLine("Invalid input pls: \n 1.Register if you have not done so.\n 2.Provide correct input ");
            }
        }

        public static void Register()
        {
            Console.Write("Enter first name:  ");
            string firstName = Console.ReadLine();
            firstName = AccountHolder._firstName;

            Console.Write("Enter last name:  ");
            string lastName = Console.ReadLine();
            lastName = AccountHolder._lastName;

            Console.Write("Enter your pin of four digits only: ");
            int pin = int.Parse(Console.ReadLine());
            pin = AccountHolder._epin;

            int accNo = GetAcctNo();

            Console.WriteLine($"Dear {firstName} {lastName} you have sucessfully registered and your Acct No is {_acctNo}");

//AccountHolder accountHolder = new AccountHolder();
//accountHolders[count] = accountHolder;
//count++;


        }
        public static void Deposit()
        {
            Console.Write("Please enter your epin:  ");
            int epin = int.Parse(Console.ReadLine());
            if(epin == AccountHolder._epin)
            {
                Console.WriteLine("Enter Acct num");
                int acctNo = int.Parse(Console.ReadLine());
                if (acctNo == GetAcctNo())
                {
                    Console.WriteLine("Enter amount you want to deposit");
                    int deposit = int.Parse(Console.ReadLine());
                    deposit = _deposit;
                    
                    

                }
            }
            else
            {
                Console.WriteLine("pls register first");
            }
            
        }

    }
}
