using System.Collections;
using yana.Core.Dto;

namespace yana.Core.Services;

public interface IRssParserService
{
    IEnumerable<RssChannel> GetChannels(string input);
}