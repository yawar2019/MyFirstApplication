using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    //WAP to print a=10,b=20,c=30
    class ConditionalConstruct
    {
        public static void Main()
        {
            int a = 30, b = 30, c = 30;
            if (a > b && a > c)
            {
                Console.WriteLine("a is the greatest");
            }
            else if (b > a && b > c)
            {
                Console.WriteLine("b is the greatest");
            }
            else
            {
                Console.WriteLine("c is the greatest");
            }
            Console.ReadLine();
        }
    }

    //Wap using Switch case for Hotel

    class Hotel
    {
        public void Naaz()
        {
            Console.WriteLine("***Welcome to Nazleen Dhaba***");
            Console.WriteLine("Choose Option below");
            Console.WriteLine("1:Doosa\n2:Idly\n3:Wada\n4:Opma");
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 1:
                    Console.WriteLine("Garam Garam Masala Doosha");
                    break;
                case 2:
                    Console.WriteLine("Thandi Idly");
                    break;
                case 3:
                    Console.WriteLine("5 days Old Wada");
                    break;
                case 4:
                    Console.WriteLine("Pani wala Opma");
                    break;
                default:
                    Console.WriteLine("Bill Sir");
                    break;
            }
            Console.ReadLine();
        }
        public void VowelsAndConsonant()
        {
            Console.WriteLine("Please Enter Alphabet");
            char alp = Convert.ToChar(Console.ReadLine());
            switch (alp)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("{0}  is Vowel", alp);
                    break;
                default:
                    Console.WriteLine("{0}  is Consonent", alp);
                    break;
            }
            Console.ReadLine();
        }
    }

    class HotelExample
    {

        public static void Main()
        {

            Hotel hobj = new Hotel();
            hobj.Naaz();
            hobj.VowelsAndConsonant();
            Console.ReadLine();
        }
    }

}
