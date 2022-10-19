namespace Builder03
{
    interface ILlantas
    {
        string informacion();
    }

    class llantas12 : ILlantas
    {
        public string informacion()
        {
            return "14 pulgadas";
        }
    }

    class llantasSuper : ILlantas
    {
        public string informacion()
        {
            return "20 pulgadas";
        }
    }

}