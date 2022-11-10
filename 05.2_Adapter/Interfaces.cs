using System.Xml;

namespace Adapter
{
    interface ImovilJSONOrigin
    {
        String GetMobilesXMLSpecifications();
    }
    interface ImovilXMLTarget
    {
        XmlDocument GetMobilesXMLSpecifications(ImovilJSONOrigin movilJSONAdapter);
    }

}