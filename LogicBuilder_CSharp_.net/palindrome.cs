using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class palindrome
    {
        public void q17()
        {
            char[] str = new char[100];
            int len = 0;

            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            foreach (char c in input)
            {
                str[len] = c;
                len++;
            }

            int start = 0;
            int end = len - 1;
            bool flag = true;

            while (start < end)
            {
                if (str[start] != str[end])
                {
                    flag = false;
                    break;
                }
                start++;
                end--;
            }

            if (flag)
                Console.WriteLine("Palindrome String");
            else
                Console.WriteLine("Not a Palindrome String");
        }
    }
}
