using System;

using SQLite;

namespace NSPersonalCloud.Common.Models
{
    [Table(TableNames.Cloud)]
    public class CloudModel
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Key { get; set; }
        public long Version { get; set; }
    }
}
