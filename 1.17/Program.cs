using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._17
{
    class Program
    {
        public static int Readname()
        {
            return int.Parse(Console.ReadLine());
        }
        public static void Sort2(out int a, out int b, int a0, int b0)
        {
            a = Math.Min(a0, b0);
            b = Math.Max(a0, b0);

        }
        public static void Sort(out int a, out int b, out int c, int a0, int b0, int c0)
        {
            Sort2(out a, out b, a0, b0);
            Sort2(out b, out c, b, c0);
            Sort2(out a, out b, a, b);
        }
        static void Main(string[] args)

        {
            int a, b, c;
            a = Readname();
            b = Readname();
            c = Readname();
            Sort(out a, out b, out c, a, b, c);
            Console.WriteLine("{0} {1} {2}", a, b, c);

            while (true)
            {
                a = NewMethod(a);
            }
        }

        private static int NewMethod(int a)
        {
            try
            {
                a = int.Parse(Console.ReadLine());

            }
            catch (FormatException)
            {
                Console.WriteLine("Error");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return a;
        }
    }
}
