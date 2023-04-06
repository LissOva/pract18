//Колыгина Елизавета 11 группа
//Вариант 9

using System;

namespace ConsoleApp9V
{
    public class ConsoleApp9V
    {
        public static double n;
        public static bool CheckNumber(string inputStr)
        {
            try
            {
                n = Convert.ToDouble(inputStr);
                return true;
            }
            catch { return false; }
        }

        public static bool CheckC(double c)
        {
            if (c == 0) return false;
            return true;
        }

        public static bool CheckXC(double x, double c)
        {
            if (x - c == 0) return false;
            return true;
        }

        public static (double, bool) Function(double a, double b, double c, double x)
        {
            if (a < 0 && x != 0)
            {
                return (a * Math.Pow(x, 2) + b * Math.Pow(x, 2), true);
            }
            else if (a > 0 && x == 0)
            {
                if (CheckXC(x, c)) return (x - a / (x - c), true);
            }
            if (CheckC(c)) return (1 + x / c, true);
            return (0, false);
        }

        static void Main()
        {
            List<double> number = new List<double>();
            Console.WriteLine("Введите значения a, b, c, x");
            int count = 4;
            while (count != 0)
            {
                string str = Console.ReadLine();
                if (CheckNumber(str))
                {
                    number.Add(n);
                    count -= 1;
                    Console.WriteLine("Принято");
                }
                else
                {
                    Console.WriteLine("Введено не число, попробуйте снова");
                }
            }

            double a = number[0];
            double b = number[1];
            double c = number[2];
            double x = number[3];

            (double, bool) f = Function(a, b, c, x);

            if (f.Item2) Console.WriteLine($"\nПри:\na = {a}\nb = {b}\nc = {c}\nx = {x}\nФункция равна: f = {f.Item1}");
            else Console.WriteLine("Невозможно посчитать");

        }
    }
}

