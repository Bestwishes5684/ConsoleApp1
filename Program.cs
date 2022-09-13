using System;
using System.Diagnostics.Metrics;

namespace figura
{
    class program
    {
        static void Main(string[] args)
        {
            Console.Write("Ведите ширину");
            var width = 0;
            width = ushort.Parse(Console.ReadLine());//16 битовое число

            Console.Write("Введите высоту");
            var height = 0;
            height = ushort.Parse(Console.ReadLine());
            var x = (Console.WindowWidth - width) / 5;
            var y = (Console.WindowHeight - height) / 2;
            var counter = 1;

            while (counter <= height)
            {
                var counter2 = 1;
                Console.SetCursorPosition(x, y++);
                while (counter2 <= width)
                {
                    Console.Write("█");
                    counter2++;
                }
                counter++;
            }

        }

    }


}