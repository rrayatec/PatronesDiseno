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

    interface ImovilMP3Target
    {
        XmlDocument GetMobilesXMLSpecifications(ImovilJSONOrigin movilJSONAdapter);
    }

}