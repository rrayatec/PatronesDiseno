using static Builder03.IMotor;

namespace Builder03
{
    internal class BuilderNormal : IBuilder
    {
        private Producto auto = new Producto();
        public void ConstrulleCarroceria()
        {
            throw new NotImplementedException();
        }

        public void ConstrulleLLantas()
        {
            throw new NotImplementedException();
        }

        public void ConstrulleMotor()
        {
            auto.ColocarMotor(new MotorBasico());
        }

        internal Producto ObtenProducto()
        {
            return auto;
        }
    }
}