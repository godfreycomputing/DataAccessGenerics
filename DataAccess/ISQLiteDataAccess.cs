using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    namespace DataAccess.SQLiteDataAccess
    {
        using SQLite;
        using System;
        using System.Collections.Generic;

        public interface ISQLiteDataAccess
        {
            void DeleteData<T>(object model) where T : class;
            List<T> GetAllData<T>() where T : class, new();
            SQLiteConnection GetConnection();
            void SaveData<T>(object model) where T : class;
            void UpdateData<T>(object model) where T : class;

            string databasePath { get; set; }
        }
    }

}
