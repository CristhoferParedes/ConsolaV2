using System;

namespace ConsolaV2
{
    internal class Logica
    {
        public static void AgregarProducto(string? cod, string? nom, string? cat, int sto, double pre) 
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
        }
        public static void AgregarCliente(string? dni, string? nom, string? ape, string? tel, string? ema, string? dir)
        {
            var CajaCliente = new Cliente
            {
                dni = dni,
                nombre = nom,
                apellido = ape,
                telefono = tel,
                email = ema,
                direccion = dir,
            };

            Cliente.listaCliente[Cliente.contador] = CajaCliente;
            Cliente.contador++;
        }
        public static void AgregarVendedor(string? cod, string? nom, string? ape, string? sue, string? tel)
        {
            var CajaVendedor = new Vendedor
            {
                codigo = cod,
                nombre = nom,
                apellido = ape,
                sueldo = sue,
                telefono = tel,
            };

            Vendedor.listaVendedor[Vendedor.contador] = CajaVendedor;
            Vendedor.contador++;
        }
        public static void AgregarProveedor(string? cod, string? nom, string? ruc, string? rep, string? tel, string? dir, string? ciu)
        {
            var CajaProveedor = new Proveedor
            {
                codigo = cod,
                nombre = nom,
                ruc = ruc,
                representante = rep,
                telefono = tel,
                direccion = dir,
                ciudad = ciu,
            };

            Proveedor.listaProveedor[Proveedor.contador] = CajaProveedor;
            Proveedor.contador++;
        }
        public static string BuscarNombreCliente(string dni)
        {
            for (int i = 0; i < Cliente.contador; i++)
            {
                if (Cliente.listaCliente[i].dni == dni)
                {
                    return Cliente.listaCliente[i].nombre +" "+ Cliente.listaCliente[i].apellido;
                }
            }
            return "No se encontro el cliente";
        }
        public static string BuscarNombreProducto(string cod)
        {
            for (int i = 0; i < Producto.contador; i++)
            {
                if (Producto.listaProductos[i].codigo == cod)
                {
                    return Producto.listaProductos[i].nombre;
                }
            }
            return "No se encontro el nombre";
        }
        public static string BuscarPrecioProducto(string cod)
        {
            for (int i = 0; i < Producto.contador; i++)
            {
                if (Producto.listaProductos[i].codigo == cod)
                {
                    return Producto.listaProductos[i].precio.ToString();
                }
            }
            return "-";
        }
        public static string BuscarNombreVendedor(string cod)
        {
            for (int i = 0; i < Vendedor.contador; i++)
            {
                if (Vendedor.listaVendedor[i].codigo == cod)
                {
                    return Vendedor.listaVendedor[i].nombre + " " + Vendedor.listaVendedor[i].apellido;
                }
            }
            return "No se encontro el vendedor";
        }
    }
}
