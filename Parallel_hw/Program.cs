using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            int num = 27;

            Task<decimal> task = new Task<decimal>(() => pr.Factorial(num));
            task.Start();
            decimal fact = task.Result;
            Console.WriteLine("Факториал {0}! = {1}", num, fact.ToString("#,#"));

            Parallel.Invoke(
                () => pr.NumberOfDigits(fact), 
                () => pr.SumOfDigits(fact)
                );
        }
        decimal Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        void NumberOfDigits(decimal n)
        {
            int count = 0;

            while (n > 1)
            {
                n /= 10;
                count++;
            }
            Console.WriteLine("Количество цифр: {0}", count);
        }
        void SumOfDigits(decimal n)
        {
            int sum = 0;

            while (n > 1)
            {
                int num = (int)(n % 10);
                n /= 10;
                sum += num;
            }
            Console.WriteLine("Сумма цифр: {0}", sum);
        }
    }
}
