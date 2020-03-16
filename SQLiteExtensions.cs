using SQLite;

using Unishare.Apps.Common.Models;

namespace Unishare.Apps.Common
{
    public static class SQLiteExtensions
    {
        public static bool CheckSetting(this SQLiteConnection database, string key, string value)
        {
            return database.Find<KeyValueModel>(key)?.Value == value;
        }

        public static string LoadSetting(this SQLiteConnection database, string key)
        {
            return database.Find<KeyValueModel>(key)?.Value;
        }

        public static bool SaveSetting(this SQLiteConnection database, string key, string value)
        {
            return database.InsertOrReplace(new KeyValueModel {
                Key = key,
                Value = value
            }) == 1;
        }
    }
}
