using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolaV2
{
    internal class Interfaz
    {
        public static void BloqueFijo()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                     ");
            Console.WriteLine("                            SISTEMA PARA GESTIONAR VENTAS                            ");
            Console.WriteLine("                                                                                     ");
            Console.ResetColor();

            Console.SetCursorPosition(0, 4);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                                     ");
            Console.ResetColor();

            for (int i = 5; i < 20; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  ");
                Console.SetCursorPosition(83, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  ");
                Console.ResetColor();
            }

            Console.SetCursorPosition(0, 20);
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.WriteLine("                                                                                     ");
            Console.ResetColor();
        }

        public static void MenuPrincipal()
        {
            string[] opciones = { "REGISTRAR", "VENTAS", "REPORTES", "MODIFICAR", "AYUDA", "SALIR" };
            int index = 0;
            ConsoleKey tecla;

            do
            {
                Console.SetCursorPosition(1, 3);

                for (int i = 0; i < opciones.Length; i++)
                {
                    if (i == index) Console.ForegroundColor = ConsoleColor.Black;                               
                    else Console.ForegroundColor = ConsoleColor.Gray;
     
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write($"   {opciones[i]}   ");
                    Console.ResetColor();
                    Console.Write(" ");
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.RightArrow)
                {
                    index++;
                    if (index > opciones.Length - 1) index = 0;
                }
                else if (tecla == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0) index = opciones.Length - 1;
                }
            } while (tecla != ConsoleKey.Enter);
        }
    }
}