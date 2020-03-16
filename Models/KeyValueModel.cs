using SQLite;

namespace Unishare.Apps.Common.Models
{
    [Table(TableNames.Settings)]
    public class KeyValueModel
    {
        [PrimaryKey]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
