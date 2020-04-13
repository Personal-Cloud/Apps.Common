using SQLite;

namespace Unishare.Apps.Common.Models
{
    [Table("AliYunOSS")]
    public class AliYunOSS
    {
        [PrimaryKey]
        public string Name { get; set; }

        public string Endpoint { get; set; }
        public string Bucket { get; set; }
        public string AccessID { get; set; }
        public string AccessSecret { get; set; }
    }
}
