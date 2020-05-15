using System;

using SQLite;

namespace NSPersonalCloud.Common.Models
{
    [Table(TableNames.AzureBlob)]
    public class AzureBlob
    {
        [PrimaryKey]
        public Guid Id {get;set;}

        [Indexed]
        public Guid Cloud { get; set; }

        [Indexed]
        public string Name { get; set; }

        public string Parameters { get; set; }
        public string Container { get; set; }

        public int Visibility { get; set; }
    }
}
