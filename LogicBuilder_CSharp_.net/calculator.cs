using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class calculator
    {
        public void q1()
        {
            int a, b;

            Console.WriteLine("enter value of A=");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter value of B=");
            b = Convert.ToInt32(Console.ReadLine());

            var abc = new addi();
            abc.additio(a, b);
            abc.subs(a, b);
            abc.multi(a, b);
            abc.div(a, b);
        }
    }


    class addi()
    {
        int a, b, sum = 0, sub, mul, divv;
        public void additio(int a, int b)
        {
            sum = a + b;
            Console.WriteLine("Addition of a and b= " + sum);
        }
        public void subs(int a, int b)
        {
            sub = a - b;
            Console.WriteLine("substraction of a and b= " + sub);
        }

        public void multi(int a, int b)
        {
            mul = a * b;
            Console.WriteLine("multiply of a and b= " + mul);
        }
        public void div(int a, int b)
        {
            if (b != 0)
            {
                divv = a / b;
                Console.WriteLine("division of a and b= " + divv);
            }
            else
            {
                Console.WriteLine("not possible");
            }
        }
    }


}
