namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int resultado = 0;

            Itarget calcu = new CCalcu();
            resultado = calcu.sumar(2, 3);
            System.Console.WriteLine("El resultado es: {0}", resultado);

            calcu = new CAdaptador();
            resultado = calcu.sumar(2, 3);
            System.Console.WriteLine("El resultado es: {0}", resultado);
        }
    }
}