using System.Dynamic;

namespace ConsolaV2
{
    public class Producto
    {
        public string? codigo;
        public string? nombre;
        public string? categoria;
        public int? stock;
        public double? precio;
        public static int contador = 0;
        public static Producto[] listaProductos = new Producto[10];
    }
}
