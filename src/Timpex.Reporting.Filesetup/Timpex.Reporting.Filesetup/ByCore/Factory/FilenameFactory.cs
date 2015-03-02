using System;

namespace Timpex.Reporting.Filesetup.ByCore.Factory
{
    public class FilenameFactory
    {
        public static Func<FilenameFactory> New = () => new FilenameFactory();

        public virtual string Create(string fqPath)
        {
            int index = fqPath.LastIndexOf("/");
            int fromLastSlash = index + 1;
            return fqPath.Substring(fromLastSlash);
        }

        public FilenameFactory()
        {
        }
    }
}