using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApplication
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);

            int b = 1;

            //Explicit casting
            byte c = (byte) b;
            Console.WriteLine();

            try
            {
                String name = "12345";
                byte number = Convert.ToByte(name);
                Console.WriteLine(number);
            }
            catch (Exception e)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }
   
            Console.WriteLine(c);
           

            Console.WriteLine("{0} {1}", byte.MinValue, byte.MaxValue);
            Console.WriteLine("{0} {1}", int.MinValue, int.MaxValue);
            Console.WriteLine("{0} {1}", double.MinValue, double.MaxValue);

        }
    }
}
