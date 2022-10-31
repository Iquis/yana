using System.Xml.Serialization;
using yana.Core.Dto;

namespace yana.Core.Models.Rss;

[XmlRoot(ElementName="channel")]
public class RssChannelModel : IBaseModel<RssChannel>
{
    [XmlElement(ElementName="title")]
    public string Title { get; set; }
    [XmlElement(ElementName="link")]
    public string Link { get; set; }
    [XmlElement(ElementName="description")]
    public string Description { get; set; }
    [XmlElement(ElementName="item")]
    public List<RssItemModel> Items { get; set; }

    public RssChannel ToDto()
    {
        return new RssChannel()
        {
            Description = Description,
            Link = Link,
            Title = Title,
            Items = Items.Select(x=> x.ToDto())
        };
    }
}