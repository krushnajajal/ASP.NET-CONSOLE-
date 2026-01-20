using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class swap2int
    {
        public void q7()
        {
            Console.Write("Enter any integer but more than 2 digit ");
            string n = Console.ReadLine();

            string rev = "";

            for (int i = n.Length - 1; i >= 0; i--)
            {
                rev += n[i];
            }
            Console.WriteLine("Reversed Number: " + rev);
        }

    }
}
