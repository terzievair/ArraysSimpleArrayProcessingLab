using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfOddNumbersInArray
{           
    class Program
    {
        static void Main(string[] args)
        {
            int odd = 0;
            var numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); ;

            foreach (int i in numbers)
            {
                if (i % 2 != 0)
                {
                    odd++;
                }
            }
                Console.WriteLine("{0}",odd);

            
                              
        }
    }
}
