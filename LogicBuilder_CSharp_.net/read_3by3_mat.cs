using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace finalassi1
{
    internal class read_3by3_mat
    {
        public void q15() 
        {
            int[,] a = new int[3, 2];
            int[,] b = new int[3, 2];
            int[,] sum = new int[3, 2];

            Console.WriteLine("Enter elements of Matrix A:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("A[{0} {1}]: ", i, j);
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nEnter elements of Matrix B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("B[{0} {1}]: ", i, j);
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                }
            }

            Console.WriteLine("\nsum:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
        
    }
}

