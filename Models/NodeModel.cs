using System;

using SQLite;

namespace Unishare.Apps.Common.Models
{
    [Table(TableNames.Nodes)]
    public class NodeModel
    {
        [PrimaryKey]
        public Guid Id { get; set; }

        [Indexed]
        public Guid CloudId { get; set; }

        public string Name { get; set; }
    }
}
