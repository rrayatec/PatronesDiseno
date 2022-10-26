namespace Patrones.AbstractFactory
{


    class LecheAlmendras : IProductoLeche
    {
        public string obtenerDatos()
        {
            return "Leche organica de almendra, 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Procesar las almendras");
        }
    }
}