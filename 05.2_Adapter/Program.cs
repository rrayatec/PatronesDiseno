using System.Xml;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Myclient cliente = new Myclient(new ImovilXMLAdapter(), new ImovilJSONAdapter());
            XmlDocument xml = cliente.GetMovilData();

            XmlNodeList lista = xml.GetElementsByTagName("Mobiles");
            XmlNodeList moviles = ((XmlElement)lista[0]).GetElementsByTagName("Apple");

            foreach (System.Xml.XmlElement xEle in moviles)
            {
                Console.WriteLine(xEle.OuterXml);
            }
        }
    }
}