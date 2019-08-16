using System;

namespace DataAccess.SQLiteDataAccess
{
    using SQLite;
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    public class SQLiteDataAccess : DataAccess.SQLiteDataAccess.ISQLiteDataAccess
    {
        public void DeleteData<T>(object model) where T : class
        {
            using (SQLiteConnection connection = this.GetConnection())
            {
                connection.CreateTable<T>(0);
                connection.Delete(model);
            }
        }

        public List<T> GetAllData<T>() where T : class, new()
        {
            using (SQLiteConnection connection = this.GetConnection())
            {
                connection.CreateTable<T>(0);
                return connection.Table<T>().ToList();
            }
        }

        public SQLiteConnection GetConnection() =>
            new SQLiteConnection(this.databasePath, true, null);

        public void SaveData<T>(object model) where T : class
        {
            using (SQLiteConnection connection = this.GetConnection())
            {
                connection.CreateTable<T>(0);
                connection.Insert(model);
            }
        }

        public void UpdateData<T>(object model) where T : class
        {
            using (SQLiteConnection connection = this.GetConnection())
            {
                connection.CreateTable<T>(0);
                connection.Update(model);
            }
        }

        public string databasePath { get; set; }
    }
}
