using SQLite;

namespace NSPersonalCloud.Common.Models
{
    [Table(TableNames.Settings)]
    public class KeyValueModel
    {
        [PrimaryKey]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
