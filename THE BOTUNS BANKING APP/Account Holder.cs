using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_BOTUNS_BANKING_APP
{
     class AcccountManager
    {

        private  string _firstName;
        private  string _lastName;
        private  int _epin;
        static AcccountManager[] accountHolders = new AcccountManager[100];
        private  string _acctNo;
        public int count = 0;
        //private static int epin;
        // private static  AccountHolder[] deposit = new AccountHolder[100];
        private decimal _deposit;
        private decimal _acctBalance;




        public AcccountManager(string firstName, string lastName, int epin, string acctNo, int deposit, decimal acctbalance)
        {
            _firstName = firstName;
            _lastName = lastName;
            _epin = epin;
            _acctNo = acctNo;
            _deposit = deposit;
            _acctBalance = acctbalance;


        }

        internal static void RegisterAccountHolder()
        {
            return;
        }

        public void SetAcctNo()
        {
            _acctNo = GenerateAcctNo();
        }


        public int GetEpin()
        {
            return _epin;
        }
        public void SetDeposit(decimal deposit)
        {
            _deposit = deposit;
        }
        public decimal GetAcctBalance()
        {
            return _acctBalance;
        }
        public string GenerateAcctNo()
        {
            Random random = new Random();
            int rand = random.Next(00000, 100000);
            int rand2 = random.Next(00000, 100000);
            string acctno = $"{rand}{rand2}";
            return acctno;
        }



    }
}
