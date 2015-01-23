using System;

namespace Timpex.Sscc.ByIO
{
    public class FileExtension
    {
        public static Func<FileExtension> New = () => new FileExtension();

        public virtual string Get()
        {
            return ".txt";
        }

        public FileExtension()
        {
        }
    }
}