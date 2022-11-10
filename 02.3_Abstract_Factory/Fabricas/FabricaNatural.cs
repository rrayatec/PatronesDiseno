
namespace Patrones.AbstractFactory
{
    class FabricaNatural : IFabrica
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
            Console.ForegroundColor = ConsoleColor.Green;
            string selection = "";
            Console.WriteLine("Estamos creando tu bebida");
            Console.WriteLine("1) Almendra\n2)Coco\n");
            selection = "2";

            switch (selection)
            {
                case "1":
                    leche = new LecheAlmendras();
                    break;
                
                case "2":
                    leche = new LecheCoco();
                break;
                
                default:
                    leche = new LecheCoco();
            }

            leche.producir();
            Console.WriteLine("Ahora extraemos el sabor");
            sabor = new SaborVainilla();
            sabor.obtener();
        }
    }
}