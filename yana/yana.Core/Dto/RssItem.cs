namespace yana.Core.Dto;

public class RssItem  : IDto
{
    public string Title { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }

    public bool IsNew { get; set; } = true;
}