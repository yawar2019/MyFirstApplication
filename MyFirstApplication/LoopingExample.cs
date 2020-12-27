using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class LoopingExample
    {
        public static void Main() {
            LoopingExample obj = new LoopingExample();
            // obj. Print5TimesName();
            //obj.PrintSumOfNumbers();
            //obj.PrintReverseNumber();
            //obj.PrintYourTable();
            obj.Printtables();
            Console.ReadLine();
        }

        void Print5TimesName()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Fahmeeda"+i);

            }
        }


        void PrintReverseNumber()
        {
            for (int i = 5; i >=1; i--)
            {
                Console.WriteLine(i);

            }
        }
        void PrintSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                  sum = sum + i;
            }
            Console.WriteLine(sum);

        }

        void PrintYourTable()
        {
            Console.WriteLine("Please Enter Table you want to Learn");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {

                Console.WriteLine("{0}x{1}={2}",n,i,n*i);


            }
        }

        void Printtables() {

            Console.WriteLine("Please Enter Table you want to Learn");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int j = 1; j <= n; j++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write("{0}x{1}={2}\t", i, j, j * i);
                }
                Console.WriteLine("\t");
            }
        } 
    }
}
