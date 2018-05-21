using System;

namespace Application
{
    class MainClass
    {
        static int ReadNumber(string message) {
            Console.Write(message);
            int number = 0;

            while (true)    
            {
                try
                {
                    number = int.Parse(Console.ReadLine());

                    if (number % 2 == 1)
                        throw new Exception("Error");

                    return number;
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Wrong format");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        static void Draw(int h) {
            int pos = 3;

            for (int i = 0; i < h; i++)
            {

                for (int j = 0; j < h; j++)
                {
                    if (j >= pos && j < h / 2)
                    {
                        Console.Write((i < h / 2) ? '/' : '\\');
                    }
                    else if (j >= h / 2 && j <= (h - pos - 1))
                    {
                        Console.Write((i < h / 2) ? '\\' : '/');
                    }
                    else
                        Console.Write(' ');

                }

                if (i < h / 2 - 1)
                    pos--;

                if (i >= h / 2)
                    pos++;

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int h = ReadNumber("Input H: ");
            Draw(h);
        }

    }
}
