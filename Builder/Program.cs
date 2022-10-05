using System;
using System.Collections.Generic;

// Builder -- Ejemplo estructural  


namespace Patrones.Builder
{

    public class MainApp
    {
        public static void Main()
        {

            // Crear director y contructores

            Director director = new Director();



            Builder b1 = new ConcreteBuilder1();

            Builder b2 = new ConcreteBuilder2();



            // Construir dos productos

            director.Construct(b1);

            Product p1 = b1.GetResult();

            p1.Show();



            director.Construct(b2);

            Product p2 = b2.GetResult();

            p2.Show();


            Console.ReadKey();

        }

    }


    class Director
    {

        public void Construct(Builder builder)
        {

            builder.BuildPartA();

            builder.BuildPartB();

        }

    }



    abstract class Builder
    {

        public abstract void BuildPartA();

        public abstract void BuildPartB();

        public abstract Product GetResult();

    }


    class ConcreteBuilder1 : Builder
    {
        private Product _product = new Product();

        public override void BuildPartA()
        {

            _product.Add("Parte A");

        }

        public override void BuildPartB()
        {

            _product.Add("Parte B");

        }

        public override Product GetResult()
        {

            return _product;

        }

    }


    class ConcreteBuilder2 : Builder
    {

        private Product _product = new Product();

        public override void BuildPartA()
        {

            _product.Add("Parte 1");

        }


        public override void BuildPartB()
        {

            _product.Add("Parte 2");

        }


        public override Product GetResult()
        {

            return _product;

        }

    }


    class Product
    {

        private List<string> _parts = new List<string>();


        public void Add(string part)
        {

            _parts.Add(part);

        }



        public void Show()
        {

            Console.WriteLine("\nPartes del producto -------");

            foreach (string part in _parts)

                Console.WriteLine(part);

        }

    }

}

