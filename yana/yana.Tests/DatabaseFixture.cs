using System;
using System.IO;
using System.Threading;
using Microsoft.Data.Sqlite;
using yana.Core.Configuration;
using yana.Core.Configuration.Implementations;

namespace yana.Tests;

public class DatabaseFixture : IDisposable
{
    private SqliteConnection sqliteConnection;
    
    public DatabaseFixture()
    {
        IDatabaseConfiguration databaseConfiguration =
            new DatabaseConfiguration()
            {
                ConnectionString = "Data Source=test.db"
            };

        if (File.Exists("test.db"))
        {
            File.Delete("test.db");
        }
        

        
        sqliteConnection = new SqliteConnection(databaseConfiguration.ConnectionString);
        
        sqliteConnection.Open();


        this.CreateSubscriptionTable();
        this.InsertSubscriptions();

    }

    private void CreateSubscriptionTable()
    {
        string createTable = "CREATE TABLE Subscriptions (Url TEXT NOT NULL UNIQUE, PRIMARY KEY(Url))";
        this.ExecuteCommand(createTable);
    }

    private void InsertSubscriptions()
    {
        string insert =
            "INSERT INTO Subscriptions (Url) VALUES('test')";
        
        this.ExecuteCommand(insert);
    }


    private void ExecuteCommand(string commandString)
    {
        SqliteCommand command = sqliteConnection.CreateCommand();
        command.CommandText = commandString;
        command.ExecuteNonQuery();
    }
    
    
    public void Dispose()
    {
        this.sqliteConnection.Close();
        this.sqliteConnection.Dispose();
        
    }
}