using System;
using System.IO;

namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    public class FileImpl
    {
        public static Func<FileImpl> New = () => new FileImpl();

        public virtual void MoveFile(string source, string dest)
        {
            File.Copy(source,dest,true);
        }

        public virtual byte[] Read(string source)
        {
            return File.ReadAllBytes(source);
        }

        public virtual void Write(string destination,byte[] bytes)
        {
            File.WriteAllBytes(destination,bytes);
        }
    }
}