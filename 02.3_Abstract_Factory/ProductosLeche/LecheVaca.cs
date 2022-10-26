namespace Patrones.AbstractFactory
{


    class LecheVaca : IProductoLeche
    {
        public string obtenerDatos()
        {
            return "Leche de Vaca natural, 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Ordeñar vaca en la granja");
        }
    }
}