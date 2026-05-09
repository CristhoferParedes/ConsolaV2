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

            for (int i = 5; i < 24; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  ");
                Console.SetCursorPosition(83, i);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.Write("  ");
                Console.ResetColor();
            }

            Console.SetCursorPosition(0, 24);
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
            var opciones = new[] { "PRODUCTOS  ", "CLIENTES   ", "VENDEDORES ", "PROVEEDORES" };
            int position = 2;
            return Utilidad.ApoyoSubMenu(opciones,position);
        }

        public static void RegistarProductos()
        {
            Console.SetCursorPosition(2, 5);
            Console.Write("Ingresar el codigo del producto : ");
            string? agregarCod = Console.ReadLine();

            Console.SetCursorPosition(2, 6);
            Console.Write("Ingresar el nombre del producto : ");
            string? agregarNom = Console.ReadLine();

            Console.SetCursorPosition(2, 7);
            Console.Write("Ingresar la categoria del producto : ");
            string? agregarCat = Console.ReadLine();

            Console.SetCursorPosition(2, 8);
            Console.Write("Ingresar stock del producto : ");
            int agregarSto = Int32.Parse(Console.ReadLine()!);

            Console.SetCursorPosition(2, 9);
            Console.Write("Ingresar precio del producto : ");
            double agregarPre = double.Parse(Console.ReadLine()!);

            Logica.AgregarProducto(agregarCod, agregarNom, agregarCat, agregarSto, agregarPre);

            Console.SetCursorPosition(2, 12);
            Console.Write("¡SE REGISTRO EL NUEVO PRODUCTO CORRECTAMENTE!");
            Console.ReadLine();

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
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("                                                         ");
        }

        public static void RegistrarClientes()
        {
            Console.SetCursorPosition(2, 5);
            Console.Write("Ingresar su DNI   :  ");
            string? agregarDni = Console.ReadLine();
            Console.SetCursorPosition(2, 6);
            Console.Write("Ingresar su nombre completo  : ");
            string? agregarNom = Console.ReadLine();
            Console.SetCursorPosition(2, 7);
            Console.Write("Ingresar su apellido completo: ");
            string? agregarApe = Console.ReadLine();

            Console.SetCursorPosition(2, 8);
            Console.Write("Ingresar su direccion   :  ");
            string? agregarDir = Console.ReadLine();

            Console.SetCursorPosition(2, 9);
            Console.Write("Ingresar su telefono   :  ");
            string? agregarTel = Console.ReadLine();

            Console.SetCursorPosition(2, 10);
            Console.Write("Ingresar su correo electronico: ");
            string? agregarCor = Console.ReadLine();

            Logica.AgregarCliente(agregarDni, agregarNom, agregarApe, agregarDir, agregarTel, agregarCor);

            Console.SetCursorPosition(2, 12);
            Console.Write("¡SE REGISTRO AL NUEVO CLIENTE CORRECTAMENTE!");
            Console.ReadLine();

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
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("                                                         ");

        }

        public static void RegistrarVendedores()
        {
            Console.SetCursorPosition(2, 5);
            Console.Write("Ingresar su codigo del vendedor: ");
            string? agregarCod = Console.ReadLine();
            Console.SetCursorPosition(2, 6);
            Console.Write("Ingresar su nombre completo    : ");
            string? agregarNom = Console.ReadLine();
            Console.SetCursorPosition(2, 7);
            Console.Write("Ingresar su apellido completo  : ");
            string? agregarApe = Console.ReadLine();

            Console.SetCursorPosition(2, 8);
            Console.Write("Ingresar su sueldo del vendedor: ");
            string? agregarSue = Console.ReadLine();

            Console.SetCursorPosition(2, 9);
            Console.Write("Ingresar su telefono           : ");
            string? agregarTel = Console.ReadLine();

            Logica.AgregarVendedor(agregarCod, agregarNom, agregarApe, agregarSue, agregarTel);

            Console.SetCursorPosition(2, 12);
            Console.Write("¡SE REGISTRO UN VEMDEDOR CORRECTAMENTE!");
            Console.ReadLine();

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
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("                                                         ");

        }

        public static void RegistrarProveedores()
        {
            Console.SetCursorPosition(2, 5);
            Console.Write("Ingresar su codigo de proveedor : ");
            string? agregarCod = Console.ReadLine();

            Console.SetCursorPosition(2, 6);
            Console.Write("Ingresar su nombre de la empresa: ");
            string? agregarNom = Console.ReadLine();

            Console.SetCursorPosition(2, 7);
            Console.Write("Ingresar su numero de RUC       : ");
            string? agregarRuc = Console.ReadLine();

            Console.SetCursorPosition(2, 8);
            Console.Write("Ingresar el nombre del representante: ");
            string? agregarRep = Console.ReadLine();

            Console.SetCursorPosition(2, 9);
            Console.Write("Ingresar su telefono           :  ");
            string? agregarTel = Console.ReadLine();

            Console.SetCursorPosition(2, 10);
            Console.Write("Ingresar su direccion           : ");
            string? agregarDir = Console.ReadLine();

            Console.SetCursorPosition(2, 11);
            Console.Write("Ingresar su Ciudad              : ");
            string? agregarCiu = Console.ReadLine();

            Logica.AgregarProveedor(agregarCod, agregarNom, agregarRuc, agregarRep, agregarTel, agregarDir ,agregarCiu);

            Console.SetCursorPosition(2, 12);
            Console.Write("¡SE REGISTRO AL PROVEEDOR CORRECTAMENTE!");
            Console.ReadLine();

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
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("                                                         ");

        }

        public static int SubMenuVentas()
        {
            var opciones = new[] { "BOLETAS  ", "FACTURAS ", "GUIAS    ", "PROFORMAS" };
            int position = 17;
            return Utilidad.ApoyoSubMenu(opciones, position);
        }

        public static void VentaBoleta()
        {
            Console.SetCursorPosition(35, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BOLETA DE VENTA");
            Console.ResetColor();

            Console.SetCursorPosition(5, 8);
            Console.Write("DNI Cliente: ");
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("            ");
            Console.ResetColor();


            Console.SetCursorPosition(5, 10);
            Console.Write("Cliente:     ");

            Console.BackgroundColor = ConsoleColor.White;

            Console.Write("                                  ");
            Console.ResetColor();


            Console.SetCursorPosition(5, 12);
            Console.Write("Codigo        Producto        Cantidad        Preocio uni        Monto");

            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 8);
            Console.ForegroundColor = ConsoleColor.Black;
            string? hola = Console.ReadLine();
            Console.ResetColor();
            
            //-------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(20, 10);
            Console.WriteLine(Logica.BuscarNombreCliente(hola));

            Console.ResetColor();
            






            //Console.SetCursorPosition(3, 15);
            //Console.Write("¡SE REGISTRO LA VENTA CORRECTAMENTE!");
            Console.ReadKey();

            Console.SetCursorPosition(3, 6);
            Console.Write("                                                                        ");
            Console.SetCursorPosition(3, 8);
            Console.Write("                                                                       ");
            Console.SetCursorPosition(3, 10);
            Console.Write("                                                                        ");
            Console.SetCursorPosition(3, 12);
            Console.Write("                                                                        ");
            Console.SetCursorPosition(3, 14);
            Console.Write("                                                                        ");
            Console.SetCursorPosition(3, 16);
            Console.Write("                                                                        ");
            Console.SetCursorPosition(3, 18);
            Console.Write("                                                                        ");
        }

        public static int SubMenuReporte()
        {
            var opciones = new[] { "PRODUCTOS  ", "CLIENTES   ", "VENDEDORES ", "PROVEEDORES", "BOLETAS    ", "FACTURAS   ", "GUIAS      ", "PROFORMAS  " };
            int position = 30;
            return Utilidad.ApoyoSubMenu(opciones, position);
        }

        public static void ReporteProductos()
        {
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Codigo |  Nombre  \t\t|   Categoria\t| Stock\t| Precio");
            
            Console.SetCursorPosition(10, 7);
            for (int i = 0; i < Producto.listaProductos?.Length; i++)
            {               
                string? cod = Producto.listaProductos[i]?.codigo;
                string? nom = Producto.listaProductos[i]?.nombre;
                string? cat = Producto.listaProductos[i]?.categoria;
                int? sto = Producto.listaProductos[i]?.stock;
                double? pre = Producto.listaProductos[i]?.precio;

                Console.SetCursorPosition(10, 7 + i);
                Console.WriteLine($"{cod}\t");
                Console.SetCursorPosition(19, 7 + i);
                Console.WriteLine($"{nom}\t");
                Console.SetCursorPosition(43, 7 + i);
                Console.WriteLine(cat);
                Console.SetCursorPosition(60, 7 + i);
                Console.WriteLine(sto);
                Console.SetCursorPosition(68, 7 + i);
                Console.WriteLine(pre);
            }

            Console.ReadKey();

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
            Console.SetCursorPosition(2, 12);
            Console.WriteLine("                                                         ");
        }

    }
}