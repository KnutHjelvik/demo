using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup
{
    public class StartpointCompression:StartPoint
    {
        private ZipFileImpl _zipFile = ZipFileImpl.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();
        private FileImpl _fileImpl = FileImpl.New();

        public StartpointCompression(ZipFileImpl zipFileImpl, DirectoryImpl directoryImpl,FileImpl fileImpl)
        {
            _zipFile = zipFileImpl;
            _directoryImpl = directoryImpl;
            _fileImpl = fileImpl;
        }

        public virtual void Start()
        {
            var destination = _directoryImpl.Root();
            var source = _directoryImpl.CreateRootDirectory();
            var destinationFile = destination + "/Reporting.Zip";
            _fileImpl.Remove(destinationFile);
            _zipFile.CreateZip(source, destinationFile);
        }

        public StartpointCompression()
        {
        }
    }
}