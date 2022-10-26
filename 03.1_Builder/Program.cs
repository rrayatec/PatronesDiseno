namespace Builder03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join('-', args));
            Director miDirector = new Director();
            BuilderNormal normal = new BuilderNormal();
            miDirector.Construye(normal);
            Producto auto1 = normal.ObtenProducto();
            auto1.MostrarAuto();            
        }
    }
}