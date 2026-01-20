using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class cal_with_switchcase
    {
        private int a, b;
        float tot;
        private char ch;
        public void q5()
        {
            Console.WriteLine("Enter value of A");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter value of B");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter symbol '+' , ' - ',' * ',' / ' ");
            ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case '+':
                    tot = a + b;
                    Console.WriteLine("Addition {0}", tot);
                    break;
                case '-':
                    tot = a - b;
                    Console.WriteLine("substraction {0}", tot);
                    break;
                case '*':
                    tot = a * b;
                    Console.WriteLine("multi {0}", tot);
                    break;
                case '/':
                    if (a == 0)
                    {
                        Console.WriteLine("IMPOSSIBLE!");
                    }
                    else
                    {
                        tot = a / b;
                        Console.WriteLine("div {0}", tot);
                    }
                    break;
            }
        }

    }
}
