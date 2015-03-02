using System;
using System.IO;

namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    public class PathImpl
    {
        public static Func<PathImpl> New = () => new PathImpl();

        public virtual string Combine(string path, string name)
        {
            return Path.Combine(path, name);
        }
    }
}