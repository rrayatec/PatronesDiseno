namespace SingletonSpace
{


    class Singleton
    {
        private static Singleton instancia;

        private string nombre;
        private int edad;

        private Singleton()
        {
            nombre = "--";
            edad = 99;

        }
        public static Singleton ObtenerInstancia()
        {
            if (instancia == null)
            {
                instancia = new Singleton();
                Console.WriteLine("Rubén registro entrada");
            }
            else
            {
                Console.WriteLine("ya no puedes registrar la entrada");
            }
            return instancia;
        }

        public override string ToString()
        {
            return string.Format("La persona {0}, tiene edad de {1} y esta trabajando en este momento", nombre, edad);
        }
        public void PonerDatos(string Nombre, int Edad)
        {
            nombre = Nombre;
            edad = Edad;
        }
        public void AlgunProceso()
        {
            Console.WriteLine("{0} esta trabajando en algo", nombre);
        }
    }
}