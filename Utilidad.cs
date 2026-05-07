namespace ConsolaV2
{
    
    // se puede construir un bloque para el menu y sub menus
    internal class Utilidad
    {
        public static int ApoyoSubMenu(string[] opcion, int position)
        {
            int index = 0;
            ConsoleKey tecla;

            do
            {
                for (int i = 0; i < opcion.Length; i++)
                {
                    Console.SetCursorPosition(position, (5 + i));

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                    if (i == index) Console.BackgroundColor = ConsoleColor.Gray;

                    Console.Write($" {opcion[i]} ");
                    Console.WriteLine();
                    Console.ResetColor();
                }

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
