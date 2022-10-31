using yana.Core.Dto;

namespace yana.Core.Services;

public interface IRssParserService
{
    RssChannel ParseChannel(string input);
}