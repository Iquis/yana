using System.Text;
using System.Xml.Serialization;
using yana.Core.Models.Rss;
using RssChannel = yana.Core.Dto.RssChannel;

namespace yana.Core.Services.Implementations;

public class RssParserService : IRssParserService
{
    public RssChannel ParseChannel(string input)
    {
        var xmlSerializer = new XmlSerializer(typeof(RssModel));
        
        var memoryStream = this.GetStreamFromXmlString(input);

        var rss = (RssModel)xmlSerializer.Deserialize(memoryStream)!;
        
        return rss.Channel.ToDto();
    }
    
    private Stream GetStreamFromXmlString(string xmlString)
    {
        byte[] byteArray = Encoding.UTF8.GetBytes(xmlString);

        return new MemoryStream(byteArray);
    }
}