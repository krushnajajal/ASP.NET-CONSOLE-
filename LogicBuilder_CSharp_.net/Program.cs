namespace finalassi1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter your choice!");
            do
            {
                Console.WriteLine("\n\n1-arithmetic\n2-sizes\n3-Swapping\n4-conversion \n5-switch arith \n6-largest,smallest-oddeve\n7-swap of 2 digit int \n8-divisible 5-7-11 \n9-leap year \n10-even add\n11-fibonaci\n12-displayarray\n13-a largestest smallest\n14-sum&avg\n15-read 3*2 matrix\n16-multiply 3*3\n17-palindrome\n18 to exit");
                n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        calculator obj = new calculator();
                        obj.q1();
                        break;
                    case 2:
                        sizeoff q2 = new sizeoff();
                        q2.q2();
                        break;
                    case 3:
                        swappping q3 = new swappping();
                        q3.q3();
                        break;
                    case 4:
                        conversssion q4 = new conversssion();
                        q4.q4();
                        break;
                    case 5:
                        cal_with_switchcase q5 = new cal_with_switchcase();
                        q5.q5();
                        break;
                    case 6:
                        odd_eve_withcomp q6 = new odd_eve_withcomp();
                        q6.q6();
                        break;
                    case 7:
                        swap2int q7 = new swap2int();
                        q7.q7();
                        break;
                    case 8:
                        div5_7_11 q8 = new div5_7_11();
                        q8.q8();
                        break;
                    case 9:
                        leapcheck q9 = new leapcheck();
                        q9.q9();
                        break;

                    case 10:
                        oddeve q10 = new oddeve();
                        q10.q10();
                        break;
                    case 11:
                        fibonacci q11 = new fibonacci();
                        q11.q11();
                        break;
                    case 12:
                        arr_display q12 = new arr_display();
                        q12.q12();
                        break;
                    case 13:
                        a_largest_smallest q13 = new a_largest_smallest();
                        q13.q13();
                        break;
                    case 14:
                        sum_and_avg q14 = new sum_and_avg();
                        q14.q14();
                        break;
                    case 15:
                        read_3by3_mat q15 = new read_3by3_mat();
                        q15.q15();
                        break;
                    case 16:
                        mul_3by3 q16 = new mul_3by3();
                        q16.q16();
                        break;
                    case 17: 
                        palindrome q17 = new palindrome();
                        q17.q17();
                        break;
                    default:
                        Console.WriteLine("WRONG choice!!!!!\npress 18 to exit");
                        break;
                }
            }
            while (n != 18);
        }
    }

}
