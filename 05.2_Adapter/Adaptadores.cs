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
                modelo = "Iphone 13"
            });
            moviles.Add(new Movil
            {
                modelo = "Iphone 14"
            });
            dynamic collectionMobiles = new { collectionMobiles = moviles };
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