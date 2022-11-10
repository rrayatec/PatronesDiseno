namespace Adapter
{
    class CAdaptador : Itarget
    {
        CCalculadoraArray adapdato = new CCalculadoraArray();
        public int sumar(int a, int b)
        {
            double r = 0;

            int[] operadores = { a, b };

            r = adapdato.suma(operadores);

            return (int)r;
        }
    }

}