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

        public static int MenuPrincipal()
        {
            var opciones = new[] { "REGISTRAR", "VENTAS", "REPORTES", "MODIFICAR", "AYUDA", "SALIR" };
            int index = 0;
            ConsoleKey tecla;

            do
            {
                Console.SetCursorPosition(1, 3);
                for (int i = 0; i < opciones.Length; i++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;

                    if (i == index) Console.BackgroundColor = ConsoleColor.Gray;                               
                        
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
            return index;
        }

        public static int SubMenuRegistrar()
        {
            var opciones = new[] { "PRODUCTOS  ", "CLIENTES   ", "VENDEDORES ", "PROVEEDORES"};
            int index = 0;
            ConsoleKey tecla;

            do
            {              
                for (int i = 0; i < opciones.Length; i++)
                {               
                    Console.SetCursorPosition(2, (5 + i));

                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                    if (i == index) Console.BackgroundColor = ConsoleColor.Gray;

                    Console.Write($" {opciones[i]} ");
                    Console.WriteLine();
                    Console.ResetColor();
                }

                tecla = Console.ReadKey(true).Key;

                if (tecla == ConsoleKey.DownArrow)
                {
                    index++;
                    if (index > opciones.Length - 1) index = 0;
                }
                else if (tecla == ConsoleKey.UpArrow)
                {
                    index--;
                    if (index < 0) index = opciones.Length - 1;
                }

                if (tecla == ConsoleKey.Escape)
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

            
            return index;
        }
        public static void OpcionProductos()
        {
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("uwu");
            Console.ReadKey(true);
        }
    }
}