using System.Xml.Serialization;

namespace yana.Core.Models.Rss
{
    [XmlRoot(ElementName="rss")]
    public class RssModel 
    {
        [XmlElement(ElementName="channel")]
        public RssChannelModel Channel { get; set; } = null!;

        [XmlAttribute(AttributeName="version")]
        public string Version { get; set; } = null!;
    }

}
