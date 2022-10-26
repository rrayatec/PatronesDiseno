
namespace Patron.Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            // invocamos el admin
            CAdminPrototipos admin = new CAdminPrototipos();

            //instanciamos dos obj
            CPersona uno = (CPersona)admin.ObtenPrototipo("Persona");
            CPersona dos = (CPersona)admin.ObtenPrototipo("Persona");

            //modificamos el estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            //Modificamos el estado
            uno.Nombre = "Sandy";
            dos.Nombre = "Sergio";

            // verificamos que cada quien tenga su estado
            Console.WriteLine(uno);
            Console.WriteLine(dos);
            Console.WriteLine("-----");

            //Creamos una instancia
            CAuto auto = new CAuto("Nissan", 20);

            //Lo colocamos como prototipo
            admin.AdicionaPrototipo("Auto", auto);

            //Obtenemos un objeto del prototipo anterior
            CAuto auto2 = (CAuto)admin.ObtenPrototipo("Auto");

            //Cambiamos el estado
            auto2.Modelo = "Honda";

            Console.WriteLine(auto);
            Console.WriteLine(auto2);
            Console.WriteLine("-----");

            //Obtenemos una instancia del COSTOSO
            CValores val = (CValores)admin.ObtenPrototipo("Valores");
            Console.WriteLine(val);
        }

    }
}