using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace x_y_right
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            Console.WriteLine("Введите значение x и y: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            if (x > 0 && y < 0)
            {
                Console.WriteLine("Числа находяться в I");
            }
            if (x > 0 && y > 0) 
            {
                Console.WriteLine("Числа находяться в II");
            }
            if (x < 0 && y < 0)
            {
                Console.WriteLine("Числа находяться в III");
            }
            if (x < 0 && y > 0) 
            {
                Console.WriteLine("Числа находяться в IV");
            }


            Console.ReadKey();
        }
    }
}
