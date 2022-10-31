namespace yana.Core.Services;

public interface ISubscriptionManager
{
    IEnumerable<string> GetSubscriptions();

    void Subscribe(string subscription);
}