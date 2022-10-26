namespace Patron.Prototype
{
    class CAdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();
        public CAdminPrototipos()
        {
            //Adicionamos los obj prototipo con los valores iniciales
            CPersona persona = new CPersona("Ruben", 18);
            prototipos.Add("Persona", persona);

            CValores valores = new CValores(1);
            prototipos.Add("Valores", valores);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }
        public object ObtenPrototipo(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }

    }
}