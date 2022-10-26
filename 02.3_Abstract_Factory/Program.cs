// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            IFabrica mifabrica = new FabricaQuimica();
            mifabrica.crearProducto();

            IProductoLeche mileche = mifabrica.ObtenerProductoLeche;
            IProductoSaborizante misabor = mifabrica.ObtenerSabor;

            mileche.producir();
            mileche.obtenerDatos();

            Console.WriteLine("_Mi malteada es de {0} y {1}", mileche.obtenerDatos(), misabor.informacion());
            Console.WriteLine("---");

            mifabrica = new FabricaNatural();
            mifabrica.crearProducto();

            mileche = mifabrica.ObtenerProductoLeche;
            misabor = mifabrica.ObtenerSabor;

            mileche.producir();
            mileche.obtenerDatos();

            Console.WriteLine("-Mi malteada es de {0} y {1}", mileche.obtenerDatos(), misabor.informacion());


        }
    }
}

