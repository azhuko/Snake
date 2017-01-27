using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snake
    {
        static void Main(string[] args)
        {
            int x1 = 1;
            int y1 = 2;
            char sym1 = '*';

            Draw(x1, y1, sym1);

            Console.ReadKey();
        }

        static void Draw(int x, int y, char sym)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }
    }
}
