namespace Builder03
{
    internal class Producto
    {
        private IMotor motor;
        private ICarroceria carroceria;
        private ILlantas llantas;

        internal void ColocarMotor(IMotor _motor)
        {
            motor = _motor;
            Console.WriteLine("Se ha colocado el motor {0} ", motor);
        }

        

        internal void MostrarAuto()
        {
            Console.WriteLine("motor: {0}", motor);
        }
    }
}