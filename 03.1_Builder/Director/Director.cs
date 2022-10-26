namespace Builder03
{
    internal class Director
    {
        internal void Construye(IBuilder _constructor)
        {
            _constructor.ConstrulleMotor();
        }
    }
}