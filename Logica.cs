namespace ConsolaV2
{
    internal class Logica
    {
        public static Producto AgregarProducto(string? cod, string? nom, string? cat, int sto, double pre) 
        {
            var CajaProducto = new Producto();

            CajaProducto.codigo = cod;
            CajaProducto.nombre = nom;
            CajaProducto.categoria = cat;
            CajaProducto.stock = sto;
            CajaProducto.precio = pre;

            Producto.listaProductos[Producto.contador] = CajaProducto;
            Producto.contador++;

            return CajaProducto;
        }
    }
}
