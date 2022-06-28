using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerofTwo
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the values of Power of Two");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(" table is ");
            for (int i = 0; i < n; i++)
            {
                double p = Math.Pow(2, i);
                Console.WriteLine(p);
            }
        }
    }
}
