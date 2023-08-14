using Slang.IDE.Cache.Internals;
using Slang.IDE.Domain.Entities.IDE;
using System;
using System.Collections.Generic;
using System.Data.SQLite;

namespace Slang.IDE.Cache.Queries
{
    public static class BookmarkQueriesCollection
    {
        private static readonly SQLiteConnection _connection;
        static BookmarkQueriesCollection()
        {
            _connection = new SQLiteConnection(Consts.ConnectionString);
            _connection.Open();
        }

        public static void CreateTable()
        {
            CheckConnection();

            using var command = new SQLiteCommand(@"CREATE TABLE IF NOT EXISTS Bookmarks (Id TEXT
, Name TEXT
, FilePath TEXT
, Line INTEGER
, Created INTEGER
, PRIMARY KEY(Id, FilePath, Line));", _connection);
            command.ExecuteNonQuery();
        }

        public static bool Insert(string id, string filePath, int line)
        {
            using var command = new SQLiteCommand("INSERT INTO Bookmarks (Id, Name, FilePath, Line, Created)" +
                " SELECT @Id, @Name || (SELECT ifnull(max(substr(Name, 9, 1)),0)+1 from Bookmarks WHERE Name like '%Bookmark%'), @FilePath, @Line, strftime('%s','now')", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@Name", "Bookmark");
            command.Parameters.AddWithValue("@FilePath", filePath);
            command.Parameters.AddWithValue("@Line", line);

            return command.ExecuteNonQuery() > 0;
        }

        public static bool Delete(string id, string filePath, int line)
        {
            using var command = new SQLiteCommand("DELETE FROM Bookmarks WHERE FilePath = @FilePath AND Line = @Line AND Id = @Id", _connection);
            command.Parameters.AddWithValue("@Id", id);
            command.Parameters.AddWithValue("@FilePath", filePath);
            command.Parameters.AddWithValue("@Line", line);

            return command.ExecuteNonQuery() > 0;
        }

        public static bool RemoveAllBookmarks()
        {
            CheckConnection();
            using var command = new SQLiteCommand("DELETE FROM Bookmarks", _connection);

            return command.ExecuteNonQuery() > 0;
        }

        public static bool Rename(string name, string filePath, int line)
        {
            using var command = new SQLiteCommand("UPDATE Bookmarks SET Name = @Name WHERE FilePath = @FilePath AND Line = @Line", _connection);
            command.Parameters.AddWithValue("@Name", name);
            command.Parameters.AddWithValue("@FilePath", filePath);
            command.Parameters.AddWithValue("@Line", line);

            return command.ExecuteNonQuery() > 0;
        }

        public static IEnumerable<Bookmark> FetchAll()
        {
            using var command = new SQLiteCommand("SELECT * FROM Bookmarks ORDER BY Created ASC", _connection);

            var reader = command.ExecuteReader();

            var list = new List<Bookmark>();
            while (reader.Read())
            {
                list.Add(new Bookmark
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    FilePath = reader.GetString(reader.GetOrdinal("FilePath")),
                    Line = reader.GetInt32(reader.GetOrdinal("Line")),
                    Id = reader.GetString(reader.GetOrdinal("Id"))
                });
            }

            return list;
        }

        public static IEnumerable<Bookmark> FetchAll(string filter)
        {
            if (string.IsNullOrEmpty(filter))
                throw new ArgumentNullException(nameof(filter));
            CheckConnection();

            using var command = new SQLiteCommand("SELECT * FROM Bookmarks WHERE FilePath = @FilePath ORDER BY Created ASC", _connection);
            command.Parameters.AddWithValue("@FilePath", filter);

            var reader = command.ExecuteReader();

            var list = new List<Bookmark>();
            while (reader.Read())
            {
                list.Add(new Bookmark
                {
                    Name = reader.GetString(reader.GetOrdinal("Name")),
                    FilePath = reader.GetString(reader.GetOrdinal("FilePath")),
                    Line = reader.GetInt32(reader.GetOrdinal("Line")),
                    Id = reader.GetString(reader.GetOrdinal("Id"))
                });
            }

            return list;
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
