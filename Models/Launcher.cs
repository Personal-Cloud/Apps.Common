using System;

using SQLite;

namespace Unishare.Apps.Common.Models
{
    [Table(TableNames.Launchers)]
    public class Launcher
    {
        public string Name { get; set; }

        public int Type { get; set; }

        [Indexed]
        public Guid Cloud { get; set; }

        public Guid Node { get; set; }

        public string AppName { get; set; }

        public string Address { get; set; }

        public string Key { get; set; }
    }
}
