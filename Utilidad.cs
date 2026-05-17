using System.Reflection.Emit;

namespace ConsolaV2
{

    // se puede construir un bloque para el menu y sub menus
    internal class Utilidad
    {
        public static int CrearMenu(string[] opcion, int position, int position2, string orientacion)
        {
            int index = 0;
            ConsoleKey tecla;

            do
            {
                if (orientacion == "Horizontal")
                {
                    Console.SetCursorPosition(position, position2);
                    for (int i = 0; i < opcion.Length; i++)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Black;

                        if (i == index) Console.BackgroundColor = ConsoleColor.Gray;

                        Console.Write($"   {opcion[i]}   ");
                        Console.ResetColor();
                        Console.Write(" ");
                    }
                }
                else
                {
                    for (int i = 0; i < opcion.Length; i++)
                    {
                        Console.SetCursorPosition(position, position2 + (5 + i));

                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;

                        if (i == index) Console.BackgroundColor = ConsoleColor.Gray;

                        Console.Write($" {opcion[i]} ");
                        Console.WriteLine();
                        Console.ResetColor();
                    }
                }

                if (orientacion == "Horizontal")
                {
                    tecla = Console.ReadKey(true).Key;
                    if (tecla == ConsoleKey.RightArrow)
                    {
                        index++;
                        if (index > opcion.Length - 1) index = 0;
                    }
                    else if (tecla == ConsoleKey.LeftArrow)
                    {
                        index--;
                        if (index < 0) index = opcion.Length - 1;
                    }
                }
                else
                {

                    tecla = Console.ReadKey(true).Key;

                    if (tecla == ConsoleKey.DownArrow)
                    {
                        index++;
                        if (index > opcion.Length - 1) index = 0;
                    }
                    else if (tecla == ConsoleKey.UpArrow)
                    {
                        index--;
                        if (index < 0) index = opcion.Length - 1;
                    }
                    else if (tecla == ConsoleKey.Escape)
                    {
                        Console.SetCursorPosition(2, 5);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(2, 6);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(2, 7);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(2, 8);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(2, 9);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(2, 10);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(2, 11);
                        Console.WriteLine("                                                         ");
                        Console.SetCursorPosition(2, 12);
                        Console.WriteLine("                                                         ");

                        return 10;
                    }
                }

            } while (tecla != ConsoleKey.Enter);


            //limpia cuando termina el bucle while y se regresa al do while anterior.
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("                                                         ");
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("                                                         ");

            return index;

        }
    }
}
