using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace NSPersonalCloud.Common
{
    public static class EnumerableExtensions
    {
        public static IEnumerable<FileSystemInfo> SortDirectoryFirstByName(this IEnumerable<FileSystemInfo> files)
        {
            return files.Where(x => !x.Attributes.HasFlag(FileAttributes.System)
                                    && !x.Attributes.HasFlag(FileAttributes.Hidden))
                        .OrderByDescending(x => x.Attributes.HasFlag(FileAttributes.Directory))
                        .ThenBy(x => x.Name);
        }
    }
}
