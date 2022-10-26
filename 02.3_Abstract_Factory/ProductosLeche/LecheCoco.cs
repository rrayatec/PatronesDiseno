namespace Patrones.AbstractFactory
{


    class LecheCoco : IProductoLeche
    {
        public string obtenerDatos()
        {
            return "Leche de coco natural, 250ml";
        }

        public void producir()
        {
            Console.WriteLine("Buscando Cocos");
        }
    }
}