using System;

using SQLite;

namespace Unishare.Apps.Common.Models
{
    [Table(TableNames.Apps)]
    public class WebApp
    {
        [Indexed]
        public Guid Cloud { get; set; }

        [Indexed]
        public string Name { get; set; }

        public string Parameters { get; set; }
    }
}
