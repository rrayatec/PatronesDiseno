namespace Patrones.AbstractFactory
{


    class SaborChocolate : IProductoSaborizante
    {
        public string informacion()
        {
            return "Chocolate Cacao Rico";
        }

        public void obtener()
        {
            Console.WriteLine("Se produce ChocoSD23");
        }
    }
}