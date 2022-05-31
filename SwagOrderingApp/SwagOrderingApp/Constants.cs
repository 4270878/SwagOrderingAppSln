using System;
using System.IO;


namespace SwagOrderingApp
{
    public static class Constants
    {
        public const string DatabaseFilename = "SwagOrdering.db2";

        public const SQLite.SQLiteOpenFlags Flags =
            SQLite.SQLiteOpenFlags.ReadWrite |
            SQLite.SQLiteOpenFlags.Create |
            SQLite.SQLiteOpenFlags.SharedCache;

        public static string DatabasePath
        {
            get
            {
                var basePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                return Path.Combine(basePath, DatabaseFilename);
            }
        }
    }
}
