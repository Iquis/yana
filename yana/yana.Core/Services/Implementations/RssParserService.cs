using System.Text;
using System.Xml.Serialization;
using yana.Core.Dto;
using yana.Core.Models;

namespace yana.Core.Services.Implementations;

public class RssParserService : IRssParserService
{
    public IEnumerable<RssChannel> GetChannels(string input)
    {
        var xmlSerializer = new XmlSerializer(typeof(Rss));
        
        var memoryStream = this.GetStreamFromXmlString(input);

        var rss = (Rss)xmlSerializer.Deserialize(memoryStream)!;

        var result = new List<RssChannel>();

        result.Add(new RssChannel()
        {
            Description = rss.Channel.Description,
            Link = rss.Channel.Link,
            Title = rss.Channel.Title,
            Items = rss.Channel.Item.Select(x => new RssItem()
            {
                Description = x.Description,
                Link = x.Link,
                Title = x.Title
            })
        });

        return result;
    }
    
    private Stream GetStreamFromXmlString(string xmlString)
    {
        byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

        return new MemoryStream(byteArray);
    }
}