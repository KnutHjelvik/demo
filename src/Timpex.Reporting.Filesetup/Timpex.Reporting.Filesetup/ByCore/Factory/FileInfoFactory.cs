using System;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Factory
{
    public class FileInfoFactory
    {
        private FileExtensionFactory _innerFileExtensionFactory = FileExtensionFactory.New();
        private FilenameFactory _innerFilenameFactory = FilenameFactory.New();

        public static Func<FileInfoFactory> New = () => new FileInfoFactory();

        public FileInfoFactory(FileExtensionFactory fileExtensionFactory, FilenameFactory filenameFactory)
        {
            _innerFileExtensionFactory = fileExtensionFactory;
            _innerFilenameFactory = filenameFactory;
        }

        public virtual FileInformation Create(string fqPath)
        {
            var fileInfo = new FileInformation();
            fileInfo.Extension = _innerFileExtensionFactory.Create(fqPath);
            fileInfo.Name = _innerFilenameFactory.Create(fqPath);
            fileInfo.Path = fqPath;
            return fileInfo;
        }

        public FileInfoFactory()
        {
        }
    }
}