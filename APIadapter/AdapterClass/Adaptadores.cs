using System.Collections.Generic;
using System.Xml;
using APIadapter;
using APIadapter.Controllers;
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

            conector c = new conector ();
            dynamic t = c.getDataAsync().Result;
            var tt = JsonConvert.DeserializeObject<List<WeatherForecast>>(t);

            dynamic collectionMobiles = new { collectionMobiles = tt };
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