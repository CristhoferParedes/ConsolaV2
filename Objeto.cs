namespace ConsolaV2
{
    internal class Producto
    {
        public string? codigo;
        public string? nombre;
        public string? categoria;
        public double stock;
        public double precio;
        public static Producto[] listaProductos = new Producto[10];
    }
}
