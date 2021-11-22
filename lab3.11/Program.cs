using System;

namespace дискриминация
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {


                Console.WriteLine("Введите a");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите b");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите c");
                double c = double.Parse(Console.ReadLine());
                double D = Math.Pow(b, 2) - 4 * a * c;
                if (D > 0)
                {
                    double x1 = -b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a;
                    double x2 = -b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c) / 2 * a;
                    Console.WriteLine("x1={0} x2={1}", x1, x2);
                }
                else if (D == 0)
                {
                    double x = -b / 2 * a;
                    Console.WriteLine("x={0}", x);
                }
                else Console.WriteLine("Корней нет");




            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
