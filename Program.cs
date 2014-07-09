using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Введите гипотенузу :");
            Double Gip = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(" Введите угол :");
            Double Ugol = Convert.ToDouble(Console.ReadLine());
            Double a = setKatA(Gip, Ugol);
            Double b = setKatB(Gip, Ugol);
            Double S = setSqere(a, b);
            Double P = setPer(a, b, Gip);

            Console.WriteLine(String.Format(" Катет a :{0}", a));
            Console.WriteLine(String.Format(" Катет b :{0}", b));
            Console.WriteLine(String.Format(" Площадь треугольника :{0}", S));
            Console.WriteLine(String.Format(" Периметр треугольника:{0}", P));
            Console.ReadLine();
        }
        public static Double setKatA(Double Gip, Double Ugol)
        {
            return Gip * Math.Cos(Ugol * Math.PI / 180);
        }

        public static Double setKatB(Double Gip, Double Ugol)
        {
            return Gip * Math.Sin(Ugol * Math.PI / 180);
        }
        public static Double setSqere(Double a, Double b)
        {
            return a * b / 2;
        }
        public static Double setPer(Double a, Double b, Double Gip)
        {
            return Gip + a + b;
        }
    }
}
