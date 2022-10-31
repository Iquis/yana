using System;
using System.Linq;
using Xunit;
using yana.Core.Services;
using yana.Core.Services.Implementations;

namespace yana.Tests;

public class RssParserServiceTests
{
    private readonly IRssParserService _rssParserService = new RssParserService();
    
    [Fact]
    public void ShouldReturnAllChannels()
    {
        string input = "<?xml version=\"1.0\" encoding=\"UTF-8\" ?>\n<rss version=\"2.0\">\n\n<channel>\n  <title>W3Schools Home Page</title>\n  <link>https://www.w3schools.com</link>\n  <description>Free web building tutorials</description>\n  <item>\n    <title>RSS Tutorial</title>\n    <link>https://www.w3schools.com/xml/xml_rss.asp</link>\n    <description>New RSS tutorial on W3Schools</description>\n  </item>\n  <item>\n    <title>XML Tutorial</title>\n    <link>https://www.w3schools.com/xml</link>\n    <description>New XML tutorial on W3Schools</description>\n  </item>\n</channel>\n\n</rss>";
        var result = _rssParserService.GetChannels(input).ToList();
        
        Assert.NotEmpty(result);
        Assert.Single(result);

        var channel = result.First();
        
        Assert.Equal("W3Schools Home Page", channel.Title);
        Assert.Equal("https://www.w3schools.com", channel.Link);
        Assert.Equal("Free web building tutorials", channel.Description);

        var items = channel.Items.ToList();
        Assert.Equal(2, items.Count);

        var item1 = items.First();
        var item2 = items[1];
        
        
        Assert.Equal("RSS Tutorial", item1.Title);
        Assert.Equal("https://www.w3schools.com/xml/xml_rss.asp", item1.Link);
        Assert.Equal("New RSS tutorial on W3Schools", item1.Description);
        
        Assert.Equal("XML Tutorial", item2.Title);
        Assert.Equal("https://www.w3schools.com/xml", item2.Link);
        Assert.Equal("New XML tutorial on W3Schools", item2.Description);
        
    }
}