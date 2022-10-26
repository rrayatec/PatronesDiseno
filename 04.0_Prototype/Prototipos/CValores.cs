
namespace Patron.Prototype
{
    class CValores : IPrototipo
    {

        private double sumatoria;
        private int m = 1;

        public int M { get => m; set => m = value; }
        public double Sumatoria { get => sumatoria; set => sumatoria = value; }
        // Constructor simple vacio
        public CValores() { }
        // Constructor Costoso
        public CValores(int pM)
        {
            m = pM;
            int n = 0;
            for (n = 0; n < 3; n++)
            {
                sumatoria += Math.Sin(n * 0.0175);

            }
        }
        public override string ToString()
        {
            return string.Format("{0}", sumatoria * m);
        }
        public object Clonar()
        {
            CValores clon = new CValores();
            clon.M = m;
            clon.Sumatoria = sumatoria;

            return clon;
        }
    }
}