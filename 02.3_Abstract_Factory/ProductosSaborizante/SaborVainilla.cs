namespace Patrones.AbstractFactory
{


    class SaborVainilla : IProductoSaborizante
    {
        public string informacion()
        {
            return "Vainilla de palo";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce Vainilla12WER");
        }
    }
}