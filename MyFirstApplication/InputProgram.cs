using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    //Asking Detail of Customer
    class InputProgram
    {
        public static void Main()
        {

            //float a = 232.23232332222222220F;
            //double b = 232.093333333333333333238367;
            //decimal c = 2323444444444444444434.0312345678998765432M;

            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(c);



            Console.WriteLine("Customer Gender");
            char Gender = Convert.ToChar(Console.ReadLine());
            if (char.ToLower(Gender)=='m')//  if (Gender == 'M'|| Gender == 'm')
            {

                Console.WriteLine("Enter CustomerId");
                int CustomerId = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter CustomerName");
                string CustomerName = Console.ReadLine();


                Console.WriteLine("Enter Price");
                float price = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine("you Are You Working?");
                bool IsWorking = Convert.ToBoolean(Console.ReadLine());



                Console.WriteLine("----Welcome To Fameeda Shopiing Mall------");

                Console.WriteLine("Customer Id:" + CustomerId + "\t" + " Customer Name:" + CustomerName + "\t" + " Price:" + price);
                Console.WriteLine("Working Status:" + IsWorking + "\t" + " Gender:" + Gender);
            }
            else {

                Console.WriteLine("Sorry this Service Not Availble Right Now");
            }
            Console.ReadLine();
        }
    }
}
