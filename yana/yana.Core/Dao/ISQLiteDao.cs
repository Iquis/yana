namespace yana.Core.Dao;

public interface ISQLiteDao
{
    Task<IEnumerable<string>> GetSubscriptions();
}