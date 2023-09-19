using Slang.IDE.Cache.Internals;
using Slang.IDE.Domain.Entities.IDE;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text;
using Slang.IDE.Shared.Extensions;

namespace Slang.IDE.Cache.Queries
{
#nullable disable
    public static class ProjectQueriesCollection
    {
        private static readonly SQLiteConnection _connection = new SQLiteConnection(Consts.ConnectionString);

        public static void CreateTable()
        {
            CheckConnection();
            using var command = new SQLiteCommand(@"CREATE TABLE IF NOT EXISTS Projects (Id TEXT
, Name TEXT
, Path TEXT
, IsPinned INTEGER
, Created INTEGER
, Updated INTEGER
, PRIMARY KEY(Id));", _connection);

            command.ExecuteNonQuery();
        }

        public static bool Insert(string id, string name, string path)
        {
            CheckConnection();

            using var command = new SQLiteCommand(@"INSERT INTO Projects (Id, Name, Path, IsPinned, Created, Updated) VALUES (@Id, @Name, @Path, 0, strftime('%s','now'), strftime('%s','now'))", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Path", path);

            return command.ExecuteNonQuery() > 0;
        }

        public static bool Delete(string id)
        {
            CheckConnection();
            using var command = new SQLiteCommand("DELETE FROM Projects WHERE Id = @Id", _connection);
            command.Parameters.AddWithValue("@Id", id);

            return command.ExecuteNonQuery() > 0;
        }

        public static bool Pin(string id)
        {
            CheckConnection();
            using var command = new SQLiteCommand("UPDATE Projects SET IsPinned = CASE WHEN IsPinned = 0 THEN 1 ELSE 0 END WHERE Id = @Id", _connection);
            command.Parameters.AddWithValue("@Id", id);

            return command.ExecuteNonQuery() > 0;
        }

        public static IEnumerable<Project> FetchAll()
        {
            CheckConnection();
            using var command = new SQLiteCommand("SELECT Id, Name, Path, IsPinned, Updated FROM Projects ORDER BY Updated ASC", _connection);

            var reader = command.ExecuteReader();

            var list = new List<Project>();
            while(reader.Read())
            {
                list.Add(new Project
                {
                    Id = reader.GetString(reader.GetOrdinal("Id")),
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    Path = reader.GetString(reader.GetOrdinal("Path")),
                    IsPinned = reader.GetBoolean(reader.GetOrdinal("IsPinned")),
                    Updated = reader.GetInt64(reader.GetOrdinal("Updated")).FromUnixTime()
                });
            }

            return list;
        }

        public static Project FetchSigle(string id)
        {
            CheckConnection();
            using var command = new SQLiteCommand("SELECT * FROM Projects WHERE Id = @Id", _connection);

            var reader = command.ExecuteReader();

            return new Project
            {
                Id = reader.GetString(reader.GetOrdinal("Id")),
                Name = reader.GetString(reader.GetOrdinal("Name")),
                Path = reader.GetString(reader.GetOrdinal("Path")),
                IsPinned = reader.GetBoolean(reader.GetOrdinal("IsPinned"))
            };
        }

        public static bool Update(string id, string name)
        {
            CheckConnection();

            using var command = new SQLiteCommand("UPDATE Projects SET Updated = strftime('%s','now'), Name = @Name WHERE Id = @Id", _connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@Id", id);

            return command.ExecuteNonQuery() > 0;
        }

        private static void CheckConnection()
        {
            if (_connection.State != System.Data.ConnectionState.Open)
            {
                _connection.Open();
            }
        }
    }
}
