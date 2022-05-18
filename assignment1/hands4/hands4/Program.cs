/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hands4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int[] arrr = new int[Convert.ToInt32(Console.ReadLine())];
            for(int i = 0; i < arrr.Length; i++)
            {
                Console.WriteLine("the element at" + i);
                arrr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arrr.Length; i++)
            {
                Console.WriteLine(arrr[i]);
            }
            Console.WriteLine();
            {

            }
        }
    }
}

*/using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hands4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the array size");
            int num = int.Parse(Console.ReadLine());
            int[] arr = new int[num];

            for (int i =0; i <num; i++)
            {
                Console.WriteLine("enter data");
                int data = int.Parse(Console.ReadLine());
                arr[i] = data;

            }
            Console.WriteLine("your data");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}
