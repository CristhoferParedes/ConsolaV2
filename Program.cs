using ConsolaV2;

Console.Clear();
Console.CursorVisible = false;

Interfaz.BloqueFijo();

int posMenu;
int posSubMenu;

do
{
    posMenu = Interfaz.MenuPrincipal();

    switch (posMenu)
    {
        case 0:
            do
            {
                posSubMenu = Interfaz.SubMenuRegistrar();
                switch (posSubMenu)
                {
                    case 0: Interfaz.RegistarProductos(); break;
                    case 1: Interfaz.RegistrarClientes(); break;
                    case 2: Interfaz.RegistrarVendedores(); break;
                }
            } while (posSubMenu != 10);
            break;
        case 1:
            do
            {
                posSubMenu = Interfaz.SubMenuVentas();
                switch (posSubMenu)
                {
                    case 0: Interfaz.VentaBoleta(); break;
                }
            } while (posSubMenu != 10);
            break;
        case 2:
            do
            {
                posSubMenu = Interfaz.SubMenuReporte();
                switch (posSubMenu)
                {
                    case 0: Interfaz.ReporteProductos(); break;
                }
            } while (posSubMenu != 10);
            break;
    }

} while (posMenu != 5);