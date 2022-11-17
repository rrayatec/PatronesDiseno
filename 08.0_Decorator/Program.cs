using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Libro libro = new Libro
            {
                Titulo = "Programación en C#",
                ISBN = "123467-789",
                Ejemplares = 20
            };

            Articulo articulo = new Articulo
            {
                ISSN = "jtu-699890",
                NumeroRevista = 3,
                Ejemplares = 7
            };

            libro.Imprimir();

            articulo.Imprimir();

            Prestamo prestamoArticulo = new Prestamo { Documento = libro };

            prestamoArticulo.Prestar("Daniel");
            prestamoArticulo.Prestar("César");

            prestamoArticulo.Imprimir();


            Console.ReadKey();
        }
    }

    abstract class Doc
    {
        public int Ejemplares {get; set;}

        public abstract void Imprimir();
    }

    class Libro : Doc
    {
        public string Titulo { get; set; }
        public string ISBN {get; set;}

        public override void Imprimir()
        {
            Console.WriteLine("Libro: ");
            Console.WriteLine("Titulo: {0}", Titulo);
            Console.WriteLine("ISBN: {0}", ISBN);
            Console.WriteLine("Ejemplares: {0}", Ejemplares);
        }
        
    }

    class Articulo : Doc
    {
        public string ISSN {get; set;}
        public int NumeroRevista {get; set;}

        public override void Imprimir()
        {
            Console.WriteLine("Articulo: ");
            Console.WriteLine("ISSN: {0}", ISSN);
            Console.WriteLine("Número Revista: {0}", NumeroRevista);
            Console.WriteLine("Ejemplares: {0}", Ejemplares);
        }
    }

    abstract class Decorator : Doc
    {

        private Doc documento;

        public Doc Documento { 
            get { return documento; } 
            set{documento = value;} 
        }

        public abstract void Prestar(string nombre);
        //public abstract void Devolver(string nombre);

        public override void Imprimir()
        {
            Documento.Imprimir();
        }
    }

    class Prestamo : Decorator
    {
        List<string> prestamos = new List<string>();

        public override void Prestar(string nombre)
        {
            prestamos.Add(nombre);
            Documento.Ejemplares--;
        }

        public override void Imprimir()
        {
            base.Imprimir();

            Console.WriteLine("Préstamos realizados: ");

            foreach (string s in prestamos)
            {
                Console.WriteLine("Ejemplar prestado a: {0}", s);
            }
        }
        

    }
}
