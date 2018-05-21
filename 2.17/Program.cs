using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._17
{
    class Program
    {
        /*  static int Input()
          {

              Console.WriteLine("Введите номер года: ");
              return Convert.ToInt32(Console.ReadLine());
          }
          static int Calc(int n)
          {
              return (n % 4 != 0 || (n % 100 == 0 && n % 400 != 0)) ? 365 : 366;
          }
          static void Output(int day)
          {
              Console.WriteLine(day);
          }
          static void Main(string[] args)
          {

              while (true)
              {
                  try
                  {
                      int n = Input();
                      int day = Calc(n);
                      Output(day);
                  }
                  catch(FormatException) {
                      Console.WriteLine("error");
                  }
              }
          }*/
        static void Main(string[] args) {


            while (true)
            {
                try
                {
                    Console.WriteLine("Input year");
                    string s = Console.ReadLine();
                    int year = 0;
                    while (!(int.TryParse(s, out year)))
                    {
                        Console.WriteLine("Error");
                        Console.WriteLine("Input year");
                        s = Console.ReadLine();
                    }
                    year = int.Parse(s);
                    if (year % 4 == 0)
                    {
                        if ((year % 100 == 0) && !(year % 400 == 0))
                        {
                            Console.WriteLine("365 days, baby!");
                        }
                        else Console.WriteLine("366 days, sugar!");
                    }
                    else Console.WriteLine("366 days, honey!");
                }

                catch(FormatException)
                {
                    Console.WriteLine("error");
                }
        }
    }
    }
}
