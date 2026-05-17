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

            Console.SetCursorPosition(0, 4);
            Console.Write("                                                                                     ");

            for (int i = 5; i < 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("  ");
                Console.SetCursorPosition(83, i);
                Console.Write("  ");
            }

            Console.SetCursorPosition(0, 29);
            Console.Write("                                                                                     ");
            Console.ResetColor();
        }

        public static int MenuPrincipal()
        {
            var opciones = new[] { "REGISTRAR", "VENTAS", "REPORTES", "MODIFICAR", "AYUDA", "SALIR" };                    
            return Utilidad.CrearMenu(opciones, 1, 3 , "Horizontal");
        }

        public static int SubMenuRegistrar()
        {
            var opciones = new[] { "PRODUCTOS  ", "CLIENTES   ", "VENDEDORES ", "PROVEEDORES" };
            string orientacion = "Vertical";

            return Utilidad.CrearMenu(opciones,2, 0, orientacion);
        }

        public static void RegistrarProductos()
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
            string orientacion = "Vertical";

            return Utilidad.CrearMenu(opciones, 17, 0, orientacion);
        }

        public static void VentaBoleta()
        {
            string[] agregarCodProducto = new string[10];
            int[]  agregarCantidadProducto = new int[10];

            Console.SetCursorPosition(35, 6);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("BOLETA DE VENTA");
            Console.ResetColor();

            Console.SetCursorPosition(5, 8);
            Console.Write("DNI Cliente: ");
            
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                                    ");
            Console.ResetColor();


            Console.SetCursorPosition(5, 10);
            Console.Write("Cliente:     ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                                    ");
            Console.ResetColor();

            Console.SetCursorPosition(5, 25);
            Console.Write("DNI Vendedor: ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                                    ");
            Console.ResetColor();

            Console.SetCursorPosition(56, 8);
            Console.Write("Nro Boleta: ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            int numeroBoleta = Boleta.contador + 1;

            Console.Write($" {Boleta.contador + 1}-2026 ");
            Console.ResetColor();

            Console.SetCursorPosition(61, 25);
            Console.Write("Total: ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("            ");
            Console.ResetColor();

            Console.SetCursorPosition(5, 12);
            Console.Write("CODIGO           PRODUCTO               CANTIDAD       PRECIO/U       MONTO");

            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(20, 8);
            Console.ForegroundColor = ConsoleColor.Black;
            string? ingresarDniCliente = Console.ReadLine();
            Console.ResetColor();

            

            //-------------------------------------------------------
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;

            Console.SetCursorPosition(20, 10);
            Console.WriteLine(Logica.BuscarNombreCliente(ingresarDniCliente));

            Console.ResetColor();

            float total = 0;

            for (int i = 0; i < 5; i++)
            {

                Console.SetCursorPosition(5, 14 + i);
                Console.Write("-");

                Console.SetCursorPosition(5, 14 + i);
                string? IngresarCod = Console.ReadLine();
                agregarCodProducto[i] = IngresarCod!;

                Console.SetCursorPosition(50, 14 + i);
                Console.Write("-");

                Console.SetCursorPosition(20, 14 + i);
                Console.WriteLine(Logica.BuscarNombreProducto(IngresarCod));

                Console.SetCursorPosition(61, 14 + i);
                string? precio = Logica.BuscarPrecioProducto(IngresarCod);
                if (precio == "") precio = "0";

                Console.WriteLine(precio);

                Console.SetCursorPosition(50, 14 + i);
                string? IngresarCan = Console.ReadLine();

                if (IngresarCan == "") IngresarCan = "0";

                agregarCantidadProducto[i] = int.Parse(IngresarCan!);

                Console.SetCursorPosition(70, 14 + i);
                float resultado =float.Parse(precio) * float.Parse(IngresarCan);
                Console.WriteLine(resultado);
                total += resultado;

                Console.SetCursorPosition(70, 25);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(total);
                Console.ResetColor();
            }


            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(20, 25);
            Console.Write("uwu");
            Console.ResetColor();

            string[] opciones = { "GUARDAR", "CANCELAR" };
            int confirmar = Utilidad.CrearMenu(opciones, 30, 27, "Horizontal");

            if (confirmar == 0)
            {
                Logica.AgregarBoleta(ingresarDniCliente,"none", agregarCodProducto, agregarCantidadProducto , total);

            }

            
            Console.ReadKey();

            Console.SetCursorPosition(3, 6);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 8);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 10);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 12);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 13);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 14);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 15);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 16);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 17);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 18);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 25);
            Console.Write("                                                                             ");
            Console.SetCursorPosition(3, 27);
            Console.Write("                                                                             ");
        }

        public static int SubMenuReporte()
        {
            var opciones = new[] { "PRODUCTOS  ", "CLIENTES   ", "VENDEDORES ", "PROVEEDORES", "BOLETAS    ", "FACTURAS   ", "GUIAS      ", "PROFORMAS  " };

            return Utilidad.CrearMenu(opciones, 30, 0, "Vertical");
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

        public static int SubMenuModificar()
        {
            var opciones = new[] { "PRODUCTOS  ", "CLIENTES   ", "VENDEDORES ", "PROVEEDORES" };
            string orientacion = "Vertical";

            return Utilidad.CrearMenu(opciones, 45, 0, orientacion);//ordenar para modificar
        }

        public static void ModificarProducto()
        {
            Console.SetCursorPosition(2, 5);
            Console.WriteLine($"ingrese un codigo de producto para modificar");
            string? cod = Console.ReadLine();
            string datosProducto = Logica.BuscarProducto(cod);
            Console.WriteLine(datosProducto);
            Console.WriteLine("Ingrese el nuevo nombre");
            string? nombreNuevo = Console.ReadLine();
            string resultado = Logica.ModificarNombreProducto(cod,nombreNuevo);
            Console.WriteLine("Se modifico el producto");



        }
    }
}