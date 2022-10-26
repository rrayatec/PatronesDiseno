// Abstract Factory -- Ejemplo estructural
namespace Patrones.AbstractFactory
{
    class ConcreteFactory1 : AbstractFactory
    {

        public override AbstractProductA CreateProductA()
        {
            return new ProductA1();
        }

        public override AbstractProductB CreateProductB()
        {
            return new ProductB1();
        }

    }
    class ProductA1 : AbstractProductA
    {
    }
    class ProductB1 : AbstractProductB
    {

        public override void Interact(AbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " interactúa con " + a.GetType().Name);
        }

    }

}

