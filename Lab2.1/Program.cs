using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов в последовательности");
            try
            {
                int n = int.Parse(Console.ReadLine());

                if (n <= 0)
                {
                    throw new Exception();
                }

                double currentMin = 1.7e+308;
                double currentMax = -1.7e+308;

                for (int i = 0; i < n; i++)
                {
                    Console.WriteLine("Введите число");
                    double currentNumber = double.Parse(Console.ReadLine());
                    if (currentNumber < currentMin)
                    {
                        currentMin = currentNumber;
                    }
                    if (currentNumber > currentMax)
                    {
                        currentMax = currentNumber;
                    }
                }
                Console.WriteLine($"Разность максимального и минимального элементов в последовательности: {currentMax - currentMin}");
            }
            catch (Exception)
            {
                Console.WriteLine("Некорректный ввод");
            }
        }
    }
}
