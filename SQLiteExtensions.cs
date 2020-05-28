using System;
using System.Linq;

using NSPersonalCloud.Common.Models;

using SQLite;

namespace NSPersonalCloud.Common
{
    public static class SQLiteExtensions
    {
        public static bool CheckSetting(this SQLiteConnection database, string key, string value)
        {
            if (database is null) throw new ArgumentNullException(nameof(database));

            return database.Find<KeyValueModel>(key)?.Value == value;
        }

        public static string LoadSetting(this SQLiteConnection database, string key)
        {
            if (database is null) throw new ArgumentNullException(nameof(database));

            return database.Find<KeyValueModel>(key)?.Value;
        }

        public static bool SaveSetting(this SQLiteConnection database, string key, string value)
        {
            if (database is null) throw new ArgumentNullException(nameof(database));

            return database.InsertOrReplace(new KeyValueModel {
                Key = key,
                Value = value
            }) == 1;
        }

        public static bool IsStorageNameUnique(this SQLiteConnection database, string name)
        {
            if (database is null) throw new ArgumentNullException(nameof(database));

            return !database.Table<AlibabaOSS>().Any(x => x.Name == name) &&
                   !database.Table<AzureBlob>().Any(x => x.Name == name);
        }
    }
}
