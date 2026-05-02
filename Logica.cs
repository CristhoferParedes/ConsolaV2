namespace ConsolaV2
{
    internal class Logica
    {
        public static Producto AgregarProducto(string? cod, string? nom, string? cat, int sto, double pre) 
        {
            var CajaProducto = new Producto
            {
                codigo = cod,
                nombre = nom,
                categoria = cat,
                stock = sto,
                precio = pre,
            };

            Producto.listaProductos[Producto.contador] = CajaProducto;
            Producto.contador++;

            return CajaProducto;
        }
    }
}
