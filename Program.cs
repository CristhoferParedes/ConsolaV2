using ConsolaV2;

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
            {
                do
                {
                    posSubMenu = Interfaz.SubMenuRegistrar();

                    switch (posSubMenu)
                    {
                        case 0:
                            Interfaz.OpcionProductos(); break;
                    }

                } while (posSubMenu != 10);
                break;
            }

    }

} while (posMenu != 5);