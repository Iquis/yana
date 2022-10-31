using System.Xml.Serialization;
using yana.Core.Dto;

namespace yana.Core.Models.Rss;

[XmlRoot(ElementName="item")]
public class RssItemModel : IBaseModel<RssItem>
{
    [XmlElement(ElementName="title")]
    public string Title { get; set; }
    [XmlElement(ElementName="link")]
    public string Link { get; set; }
    [XmlElement(ElementName="description")]
    public string Description { get; set; }

    public RssItem ToDto()
    {
        return new RssItem()
        {
            Title = Title,
            Link = Link,
            Description = Description
        };
    }
}