using System;

using SQLite;

namespace Unishare.Apps.Common.Models
{
    [Table(TableNames.AzureBlob)]
    public class AzureBlob
    {
        [PrimaryKey]
        public Guid Id {get;set;}

        [Indexed]
        public Guid CloudId { get; set; }

        [Indexed]
        public string Name { get; set; }

        public string Parameters { get; set; }

        public int Visibility { get; set; }
    }
}
