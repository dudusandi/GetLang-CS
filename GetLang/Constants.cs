using System;
using System.IO; // Add this using directive for Path.Combine
using SQLite; // Add this using directive for SQLite flags

namespace GetLang
{
    public static class Constants
    {
        public const string DatabaseFilename = "date.db3";

        public const SQLiteOpenFlags Flags =
            // open the database in read/write mode
            SQLiteOpenFlags.ReadWrite |
            // create the database if it doesn't exist
            SQLiteOpenFlags.Create |
            // enable multi-threaded database access
            SQLiteOpenFlags.SharedCache;


        public static string DatabasePath =>
            Path.Combine(FileSystem.AppDataDirectory, DatabaseFilename);
    }
}
