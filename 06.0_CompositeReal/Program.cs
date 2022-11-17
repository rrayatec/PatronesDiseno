// Patrón Composite -- Ejemplo real


using System;
using System.Collections.Generic;

namespace Patrones.CompositeReal
{

    /// <summary>

    /// MainApp startup class for Real-World 

    /// Composite Design Pattern.

    /// </summary>

    class MainApp
    {

        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {

            // Create a tree structure 

            CompositeElement root =

              new CompositeElement("Diagrama");

            root.Add(new PrimitiveElement("Línea"));

            root.Add(new PrimitiveElement("Círculo"));

            root.Add(new PrimitiveElement("Cuadrado"));



            // Create a branch

            CompositeElement comp =

              new CompositeElement("Dos círculos");

            comp.Add(new PrimitiveElement("Círculo 1"));

            comp.Add(new PrimitiveElement("Círculo 2"));

            root.Add(comp);



            // Add and remove a PrimitiveElement

            PrimitiveElement pe =

              new PrimitiveElement("Línea 2");

            root.Add(pe);


            // Recursively display nodes

            root.Display(1);

            //pe.Add(null);


            // Wait for user

            Console.ReadKey();

        }

    }



    /// <summary>

    /// The 'Component' Treenode

    /// </summary>

    abstract class DrawingElement
    {
        protected string _name;


        // Constructor

        public DrawingElement(string name)
        {
            this._name = name;
        }


        public abstract void Add(DrawingElement d);

        public abstract void Remove(DrawingElement d);

        public abstract void Display(int indent);

    }



    /// <summary>

    /// The 'Leaf' class

    /// </summary>

    class PrimitiveElement : DrawingElement
    {
        // Constructor

        public PrimitiveElement(string name): base(name)
        {

        }

        public override void Add(DrawingElement c)
        {
            Console.WriteLine("Este elemento no puede tener hijos");
        }

        public override void Remove(DrawingElement c)
        {
            Console.WriteLine("Este elemento no tiene hijos");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(
              new String('-', indent) + " " + _name);
        }
    }



    /// <summary>

    /// The 'Composite' class

    /// </summary>

    class CompositeElement : DrawingElement
    {

        private List<DrawingElement> elements = new List<DrawingElement>();


        // Constructor

        public CompositeElement(string name): base(name)
        {

        }

        public override void Add(DrawingElement d)
        {
            elements.Add(d);
        }

        public override void Remove(DrawingElement d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + _name);


            // Display each child element on this node

            foreach (DrawingElement d in elements)
            {
                d.Display(indent + 2);
            }
        }
    }
}
 

