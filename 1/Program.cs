using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Curcle.Radius(5);
            Curcle.Length(5);
            Curcle.S(5);
            Curcle.XY(5, 8, 2);
            Curcle.XY(5, 4, 2);
            Console.ReadKey();
        }
    }
    static class Curcle
    {
        static public void Radius(int r)
        {
            if (r>0)
            {
                Console.WriteLine("r = {0}", r);
            }
            else
            {
                Console.WriteLine("Ошибка. Радиус должен быть больше 0");
            }
        }
        static public void Length(int r)
        {
            if (r>0)
            {
                double p = 2 * Math.PI * r;
                Console.WriteLine("p = {0}", Math.Round(p, 2));
            }
            else
            {
                Console.WriteLine("Ошибка. Радиус должен быть больше 0");
            }
        }
        static public void S(int r)
        {
            if (true)
            {
                double s = Math.PI * (r * r);
                Console.WriteLine("s = {0}", Math.Round(s, 2));
            }
            else
            {
                Console.WriteLine("Ошибка. Радиус должен быть больше 0");
            }
        }
        static public void XY(int r, int x, int y)
        {
            bool xy = true;
            if (r>0)
            {
                if (Math.Abs(x) >= r || Math.Abs(y) >= r)
                {
                    xy = false;
                }
                if (xy == true)
                {
                    Console.WriteLine("Точка x{0},y{1} принадлежит окружности с радиусом {2}", x, y, r);
                }
                else
                {
                    Console.WriteLine("Точка x{0},y{1} НЕ принадлежит окружности с радиусом {2}", x, y, r);
                }
            }
            else
            {
                Console.WriteLine("Ошибка. Радиус должен быть больше 0");
            }
        }
    }
}
