using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace THE_BOTUNS_BANKING_APP
{
     interface IAccountManager
    {
        public AcccountManager RegisterAccountHolder(string firstName, string lastName, string epin, int acctNo);
       public AcccountManager RegisterAccountHolders();
    }
}
