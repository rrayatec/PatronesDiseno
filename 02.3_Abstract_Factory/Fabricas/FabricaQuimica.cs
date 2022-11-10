
namespace Patrones.AbstractFactory
{
    class FabricaQuimica : IFabrica
    {
        private IProductoLeche leche;
        private IProductoSaborizante sabor;
        
        public IProductoLeche ObtenerProductoLeche
        {
            get { return leche; }
        }

        public IProductoSaborizante ObtenerSabor
        {
            get { return sabor; }
        }

        public void crearProducto()
        {
            Console.WriteLine("Estamos produciendo tu malteada");
            leche = new LecheVaca();
            sabor = new SaborChocolate();
        }
    }
}