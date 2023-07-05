using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_0_Vinicius_Flyssak
{
    internal class Program
    {

        static void Letreiro()
        {
            var textoOriginal: String(30) = '';
        }
        static void Bola()
        {
            var dx = 1;
            var dy = 1;
            var x = 0;
            var y = 0;

            while (true)
            {
                if (Console.KeyAvailable) break;
                Console.SetCursorPosition(x, y);
                Console.Write('0');
                Console.SetCursorPosition(x, y);
                Console.Write(' ');

                Console.CursorVisible = false;
                x += dx;
                y += dy;
                if (x == 0) dx = 1;
                if (x == Console.WindowWidth) dx = -1;
                if (y == Console.WindowHeight) dy = -1;
                if (y == 0) dy = 1;
                Console.CursorVisible = true;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}

