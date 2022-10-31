namespace yana.Core.Dto;

public class RssChannel : IDto
{
    public string Title { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public IEnumerable<RssItem> Items { get; set; }
}