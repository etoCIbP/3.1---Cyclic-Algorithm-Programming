using System;

namespace _3._1___Cyclic_Algorithm_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            //  3.1 Оператор цикла с параметром
            Console.WriteLine("Введите двухзначное число n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите x");
            double x = double.Parse(Console.ReadLine());

            double S = 0; //сумма Е (S)
            double k = 1; //переменная которая не помещается в две функции
            double P = 0; //произведение П (P)
            double O = 0; //ответ

            for (k = 1; k <= n; k++)
            {
                S = Math.Pow(-3, 3 * k - 1) / 2 * (k - 2) * Math.Pow(x, 3 * k + 1);
            }
            for (int m = 1; m <= k + 2; m++)
            {
                P = Math.Pow(m, 3) - 8 / m - 4;
            }
            O = S * P;

            Console.Write("Ответ = " + O);
        }
    }
}
