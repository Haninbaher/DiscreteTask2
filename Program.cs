using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace haneen_baher_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the first number");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the first number");
            int y = int.Parse(Console.ReadLine());

            for(int n=x;n<=y;n++)
            {
                int sum = 0;
                for (int i = 1; i < n; i++)
                {
                    
                    if (n % i == 0)
                        sum += i;
                }
                if (sum == n)
                    Console.WriteLine(n);

            }
            Console.ReadKey();
        }
    }
}
