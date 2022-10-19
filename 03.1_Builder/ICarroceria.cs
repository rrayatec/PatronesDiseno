namespace Builder03
{
    interface ICarroceria
    {
        string caracteristicas();
    }

    class CarroceriaBasica : ICarroceria
    {
        public string caracteristicas()
        {
            return "carroceria de metal";
        }
    }
    class CarroceriaEspecial : ICarroceria
    {
        public string caracteristicas()
        {
            return "carroceria de fibra";
        }
    }




}