using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class leapcheck
    {
        public void q9()
        {
            int year;
            Console.WriteLine("Enter year to check leap or not");
            year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0)
            {
                if (year % 100 == 0)
                {
                    if (year % 400 == 0)
                    {
                        Console.WriteLine("IT IS A LEAP YEAR!!");
                    }
                    else
                    {
                        Console.WriteLine("NOT A LEAP YEAR:(");
                    }
                }
                else
                {
                    Console.WriteLine("IT IS A LEAP YEAR!!");
                }
            }
            else
            {
                Console.WriteLine("NOT A LEAP YEAR:(");
            }
        }
    }
}
