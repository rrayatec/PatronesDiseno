// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    interface IFabrica
    {
        void crearProducto();
        IProductoLeche ObtenerProductoLeche { get; }
        IProductoSaborizante ObtenerSabor { get; }
        

    }
}

