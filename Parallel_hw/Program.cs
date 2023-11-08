using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int num = 25;

            Task<decimal> task = new Task<decimal>(() => pr.Factorial(num));
            task.Start();
            Console.WriteLine("Факториал {0}! = {1}", num, task.Result.ToString("#,#"));
        }
        decimal Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        void NumberOfDigits(decimal n)
        {
            
        }
    }
}
