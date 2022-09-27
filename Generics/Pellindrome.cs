using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
     class Pellindrome
    {
        public  void Pellindromee()
        {
            string inputStr, r;
            Console.WriteLine("Pls input a word to know if it is a pellindrome");
            inputStr = Console.ReadLine();
            char[] letter = inputStr.ToCharArray();
            Array.Reverse(letter);
            r = new string(letter);
            bool check = inputStr.Equals(r, StringComparison.OrdinalIgnoreCase);
            if (check == true)
            {
                Console.WriteLine("This string " + inputStr + " is a Pellindrome!");
            }
            else
            {
                Console.WriteLine("This string " + inputStr + " is not a Pellindrome!");
            }
            Console.ReadLine();



        }
    }
}
