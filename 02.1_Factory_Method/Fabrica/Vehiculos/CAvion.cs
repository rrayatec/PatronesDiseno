namespace MetodoFabrica02.Fabrica
{
    internal class CAvion : IVehiculo
    {
        public void Encender()
        {
            Console.WriteLine("Encendiendo el Avion");
        }
        public void Acelerar()
        {
            Console.WriteLine("Acelerando el Avion");
        }
        public void Frenar()
        {
            Console.WriteLine("Frenando el Avion");
        }
        public void Girar()
        {
            Console.WriteLine("Girando el Avion");
        }
    }
}