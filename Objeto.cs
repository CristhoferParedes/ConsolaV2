namespace ConsolaV2
{
    public class Producto
    {
        public string? codigo;
        public string? nombre;
        public string? categoria;
        public int? stock;
        public double? precio;
        public static int contador = 0; //{Get; Set;}
        public static Producto[]? listaProductos = new Producto[10];
    }

    public class Cliente
    {
        public string? dni;
        public string? nombre;
        public string? apellido;
        public string? telefono;
        public string? email;
        public string? direccion;
        public static int contador = 0;
        public static Cliente[]? listaCliente = new Cliente[10];
    }

    public class Vendedor
    {
        public string? codigo;
        public string? nombre;
        public string? apellido;
        public string? sueldo;
        public string? telefono;
        public static int contador = 0;
        public static Vendedor[]? listaVendedor = new Vendedor[10];
    }

    public class Proveedor
    {
        public string? codigo;
        public string? nombre;
        public string? ruc;
        public string? representante;
        public string? telefono;
        public string? direccion;
        public string? ciudad;
        public static int contador = 0;
        public static Proveedor[]? listaProveedor = new Proveedor[10];
    }

    public class Boleta
    {
        public int? numeroBoleta;
        public string? dniCliente;
        public string? codigoVendedor;
        public string[]? codigoProducto = new string[10];
        public int[]? cantidadProducto;
        public float? total;
        public static int contador = 0;
        public static Boleta[]? listaBoleta = new Boleta[10];
    }
}
