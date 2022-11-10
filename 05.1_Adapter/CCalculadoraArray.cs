namespace Adapter
{
    class CCalculadoraArray
    {
        public double suma(int[] operadores)
        {
            int n = 0;
            double r = 0;

            for (n = 0; n < operadores.Length; n++)
            {
                r += operadores[n];
            }
            return r;
        }
    }
}