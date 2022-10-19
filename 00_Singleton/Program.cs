namespace SingletonSpace
{

    class Program
    {
        static void Main(string[] args)
        {
            Singleton uno = Singleton.ObtenerInstancia();
            uno.PonerDatos("ruben", 31);
            uno.AlgunProceso();
            
            Singleton dos = Singleton.ObtenerInstancia();
            dos.PonerDatos("Sandy", 31);
        }
    }

}