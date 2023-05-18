using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число" + Environment.NewLine);
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine($"Число положительное, {number + 5}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine($"Число отрицательное, {number - 5}");
                Console.ReadKey();
            }
        }
    }
}
