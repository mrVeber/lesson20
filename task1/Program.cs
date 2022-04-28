using System;

namespace task1
{
    class Program
    {
        delegate double MyDelegate(double r);
        static void Main(string[] args)
        {
            Console.Write("Введите радиус окружности: ");
            double r = Convert.ToDouble(Console.ReadLine());

            MyDelegate myDelegate = Circumference;
            double d = myDelegate(r);
            Console.Write($"\nДлинна окружности равна: {d:F2}");

            myDelegate = AreaOfACircle;
            double s = myDelegate(r);
            Console.Write($"\nПлощадь круга равна: {s:F3}");

            myDelegate = BallVolume;
            double v = myDelegate(r);
            Console.Write($"\nОбъём круга равен: {v:F4}");
            Console.ReadLine();

        }

        static double Circumference(double r) => 2 * Math.PI * r;
        static double AreaOfACircle(double r) => Math.PI * Math.Pow(r, 2);
        static double BallVolume(double r) => 4 / 3 * Math.PI * Math.Pow(r, 3);

    }
}
