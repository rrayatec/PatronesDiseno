using System.Xml;
using Newtonsoft.Json;

namespace Adapter
{
    class Myclient
    {
        private ImovilXMLTarget _movilXmlTarget;
        private ImovilJSONOrigin _movilJSONOrigin;

        public Myclient(ImovilXMLTarget movilXmlTarget, ImovilJSONOrigin movilJSONOrigin)
        {
            _movilXmlTarget = movilXmlTarget;
            _movilJSONOrigin = movilJSONOrigin;
        }

        public XmlDocument GetMovilData()
        {
            return _movilXmlTarget.GetMobilesXMLSpecifications(_movilJSONOrigin);
        }
    }
}