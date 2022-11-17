using System;

namespace Patrones.FacadeReal
{

    /// <summary>

    /// MainApp startup class for Real-World 

    /// Facade Design Pattern.

    /// </summary>

    class MainApp
    {

        /// <summary>

        /// Entry point into console application.

        /// </summary>

        static void Main()
        {

            // Facade

            Seleccion seleccion = new Seleccion();



            // Evaluar elegibilidad

            Candidato candidato = new Candidato { Nombre = "Juan Urrutia", Idioma = "FR", Promedio = 86 };

            bool elegible = seleccion.EsElegible(candidato, "MIT");



            Console.WriteLine("\n" + candidato.Nombre +

                " ha sido " + (elegible ? "Aprobado" : "Rechazado"));



            // Wait for user

            Console.ReadKey();

        }

    }



    /// <summary>

    /// Clase Promedio

    /// </summary>

    class Promedio
    {

        public bool CumplePromedio(Candidato c, string uni)
        {
            Console.WriteLine("Comprobando promedio para " + c.Nombre);
            if (c.Promedio > 85 && uni == "MIT") { return true; } else { return false; }
        }
    }



    /// <summary>

    /// Clase Idioma

    /// </summary>

    class Idioma
    {

        public bool HablaIdioma(Candidato c, string uni)
        {
            Console.WriteLine("Comprobando idioma para " + c.Nombre);

            if (c.Idioma == "EN" && uni == "MIT") { return true; } else { return false; }
        }
    }


    class Nombre
    {

        public bool EsJuan(Candidato c, string uni)
        {
            Console.WriteLine("Comprobando nombre para " + c.Nombre);

            if (c.Nombre != "Juan" && uni == "MIT") { return true; } else { return false; }
        }
    }

  
    /// <summary>

    /// clase Candidato

    /// </summary>

    class Candidato
    {
        public Candidato()
        {
        }

        public string Nombre
        {
            get; set;
        }

        public string Idioma
        {
            get; set;
        }

        public int Promedio
        {
            get; set;
        }
    }



    /// <summary>

    /// The 'Facade' class

    /// </summary>

    class Seleccion
    {

        private Promedio _promedio = new Promedio();

        private Idioma _idioma = new Idioma();


        public bool EsElegible(Candidato c, string uni)
        {
            Console.WriteLine("{0} aplica para intercambio en {1} \n", c.Nombre, uni);

            bool elegible = true;

            if (!_promedio.CumplePromedio(c, uni))
            {
                elegible = false;
            }

            else if (!_idioma.HablaIdioma(c, uni))
            {
                elegible = false;
            }

            return elegible;

        }

    }

}

