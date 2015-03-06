using System;
using System.IO.Compression;
namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    
    public class ZipFileImpl
    {
        public static Func<ZipFileImpl> New = () => new ZipFileImpl();

        public virtual void CreateZip(string sourceDirectory, string destinationDirectory)
        {
            ZipFile.CreateFromDirectory(sourceDirectory,destinationDirectory,CompressionLevel.Optimal,true);   
        }

        public ZipFileImpl()
        {
        }
    }
}