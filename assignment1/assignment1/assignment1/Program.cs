using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name :");
            string name = Console.ReadLine();
            Console.WriteLine("Hi! {0} welcome to the world of c#", name);
            Console.ReadLine();
        }
    }
}
/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your number :");
            number = Convert.ToInt32(Console.ReadLine());
            if (number %2 == 0)
            {
                Console.WriteLine("even number");

            }
            else
            {
                Console.WriteLine("odd number");
            }
            Console.ReadLine();
        }
    }
}
*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dotnet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            int number3;
            Console.WriteLine("Enter your number:");
            number1 = Convert.ToInt32(Console.ReadLine());
            number2 = Convert.ToInt32(Console.ReadLine());
            number3 = Convert.ToInt32(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("number1 is greater");
            }
            else if (number2 > number3)
            {
                Console.WriteLine("number2 is greater");
            }
            else
            {
                Console.WriteLine("number3 is greater");
            }
            Console.ReadLine();
        }
    }
}
