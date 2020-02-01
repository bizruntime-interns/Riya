using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    class Exception_Handling
    {
        static void Main(string[] args)
        {
            int a, b, div;
            Console.WriteLine("enter 1st number");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter 2nd number");
            b = Convert.ToInt32(Console.ReadLine());
            div = Convert.ToInt32(Console.ReadLine());
            try
            {

                div = a / b;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            Console.WriteLine("result of division is : " + div);
            Console.ReadLine();


        }
    }
}
