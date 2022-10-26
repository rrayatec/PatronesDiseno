namespace Builder03
{
    internal interface IMotor
    {
        string especificaciones();

        class MotorBasico : IMotor
        {
            public string especificaciones()
            {
                return "4 cilindors";
            }
        }
        class MotorGrande : IMotor
        {
            public string especificaciones()
            {
                return "8 cilindors";
            }
        }
    }
}