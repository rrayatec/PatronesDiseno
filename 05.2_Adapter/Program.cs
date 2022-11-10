using System.Xml;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var cliente = new Myclient(new ImovilXMLAdapter(), new ImovilJSONAdapter());
            var xml = cliente.GetMovilData();

            XmlNodeList lista = xml.GetElementsByTagName("Mobiles");
            XmlNodeList moviles = ((XmlElement)lista[0]).GetElementsByTagName("collectionMobiles");

            foreach (System.Xml.XmlElement xEle in moviles)
            {
                Console.WriteLine(xEle.OuterXml);
            }
        }
    }
}