// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fabrica 1
            IFabrica mifabrica = new FabricaQuimica();
            mifabrica.crearProducto();

            IProductoLeche _leche_ = mifabrica.ObtenerProductoLeche;
            IProductoSaborizante _sabor_ = mifabrica.ObtenerSabor;

            _leche_.producir();
            _leche_.obtenerDatos();

            Console.WriteLine("_Mi malteada es de {0} y {1}", _leche_.obtenerDatos(), _sabor_.informacion());
            Console.WriteLine("---");
            

            
            // Fabrica 2
            mifabrica = new FabricaNatural();
            mifabrica.crearProducto();

            _leche_ = mifabrica.ObtenerProductoLeche;
            _sabor_ = mifabrica.ObtenerSabor;

            _leche_.producir();
            _leche_.obtenerDatos();

            Console.WriteLine("-Mi malteada es de {0} y {1}", _leche_.obtenerDatos(), _sabor_.informacion());


        }
    }
}

