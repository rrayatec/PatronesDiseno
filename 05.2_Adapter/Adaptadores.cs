using System.Xml;
using Newtonsoft.Json;

namespace Adapter
{
    class ImovilJSONAdapter : ImovilJSONOrigin
    {
        public string GetMobilesXMLSpecifications()
        {
            List<Movil> moviles = new List<Movil>();
            moviles.Add(new Movil
            {
                modelo = "Iphone 13",
                costo = 345.00
            });
            moviles.Add(new Movil
            {
                modelo = "Iphone 14",
                costo = 345.00
            });
            dynamic collectionMobiles = new { Apple = moviles };
            return JsonConvert.SerializeObject(collectionMobiles);

        }
    }
    class ImovilXMLAdapter : ImovilXMLTarget
    {
        public XmlDocument GetMobilesXMLSpecifications(ImovilJSONOrigin movilJSONAdapter)
        {
            string jsonMovil = movilJSONAdapter.GetMobilesXMLSpecifications();
            XmlDocument doc = JsonConvert.DeserializeXmlNode(jsonMovil, "Mobiles", true);
            return doc;
        }
    }
}