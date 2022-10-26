namespace MetodoFabrica02.Fabrica.Creadores
{
    internal class CCreador
    {
        internal static IVehiculo MetodoFabrica(int dinero)
        {
            IVehiculo temp = null;

            if (dinero > 1000)
            {
                temp = new CAvion();
            }
            return temp;
        }

    }
}