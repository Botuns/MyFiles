using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_BOTUNS_BANKING_APP
{
      class AcccountManager : IAccountManager
    {
        private static string firstName;
        private static string lastName;
        private static int epin;
        private static string acctNo;
        private static int deposit;
        private static decimal acctbalance;
        private AcccountManager[]_accountHolders = new AcccountManager[100];
        private AcccountManager accountHolder = new AcccountManager(firstName,lastName,epin,acctNo,deposit,acctbalance);
        private int _noOfAcctHolders = 0;

        



        public AcccountManager RegisterAccountHolder(string firstName, string lastName, string epin, int acctNo)
        {
            return accountHolder;

        }

        public void RegisterAccountHolders()
        {
            Console.WriteLine("Enter your first name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter your epin");
            epin = int.Parse(Console.ReadLine());

            Console.WriteLine($"Dear {firstName}  {lastName} your account number is {acctNo}");

        }

        AcccountManager IAccountManager.RegisterAccountHolders()
        {
            throw new NotImplementedException();
        }
    }

}
