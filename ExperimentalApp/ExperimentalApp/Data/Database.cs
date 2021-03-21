using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExperimentalApp.Data
{
    public class Database
    {
        readonly SQLiteAsyncConnection database;

        public Database(string dbPath)
        {
            this.database = new SQLiteAsyncConnection(dbPath);
            database.CreateTableAsync<Models.Data>().Wait();
        }

        //TODO Create Getters and Setters for the DB
    }
}
