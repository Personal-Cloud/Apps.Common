using System;

using SQLite;

namespace NSPersonalCloud.Common.Models
{
    [Table(TableNames.Devices)]
    public class DeviceModel
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        public string Host { get; set; }
        public int Port { get; set; }

        public string Name { get; set; }
    }
}
