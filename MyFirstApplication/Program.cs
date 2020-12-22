using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class Program
    {
        public static void Main()
        {
            Program obj = new Program();

            int a = obj.Add();
            Console.WriteLine(a);

            Console.ReadLine();
        }

         public int Add()
        {
            int a = 10, b = 20;
            return a + b;
        }
    }
}
