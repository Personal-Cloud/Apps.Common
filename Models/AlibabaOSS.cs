using System;

using SQLite;

namespace NSPersonalCloud.Common.Models
{
    [Table(TableNames.AlibabaOSS)]
    public class AlibabaOSS
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        [Indexed]
        public Guid Cloud { get; set; }

        [Indexed]
        public string Name { get; set; }

        public string Endpoint { get; set; }
        public string Bucket { get; set; }
        public string AccessID { get; set; }
        public string AccessSecret { get; set; }

        public int Visibility { get; set; }
    }
}
