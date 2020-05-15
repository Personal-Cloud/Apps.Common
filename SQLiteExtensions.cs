using System.Linq;

using SQLite;

using NSPersonalCloud.Common.Models;

namespace NSPersonalCloud.Common
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

        public static bool IsStorageNameUnique(this SQLiteConnection database, string name)
        {
            return !database.Table<AlibabaOSS>().Any(x => x.Name == name) &&
                   !database.Table<AzureBlob>().Any(x => x.Name == name);
        }
    }
}
