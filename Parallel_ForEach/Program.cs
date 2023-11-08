using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program pr = new Program();
            List<int> list = new List<int>();

            pr.FillArray(list);

            Parallel.ForEach<int>(list, pr.Print);
        }
        void FillArray(List<int> arr)
        {
            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                arr.Add(rnd.Next(1, 20));
            }
        }
        decimal Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }
        void Print(int n)
        {
            Console.WriteLine("Задача №{0}: Факториал {1}! = {2}", Task.CurrentId, n, Factorial(n).ToString("#,#"));
        }
    }
}
