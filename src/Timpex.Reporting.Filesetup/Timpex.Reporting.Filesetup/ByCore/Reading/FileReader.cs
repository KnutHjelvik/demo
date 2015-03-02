using System;
using System.Collections.Generic;
using Timpex.Reporting.Filesetup.ByCore.Factory;
using Timpex.Reporting.Filesetup.ByCore.Folder;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Reading
{
    public class FileReader
    {
        public static Func<FileReader> New = () => new FileReader();

        private FolderSettings _folderSettings = FolderSettings.New();
        private DirectoryImpl _directoryImpl = DirectoryImpl.New();
        private FileInfoFactory _fileInfoFactory = FileInfoFactory.New();
        private List<FileInformation> _files = new List<FileInformation>();

        public FileReader(FolderSettings folderSettings, DirectoryImpl directoryImpl, FileInfoFactory fileInfoFactory)
        {
            _fileInfoFactory = fileInfoFactory;
            _directoryImpl = directoryImpl;
            _folderSettings = folderSettings;
        }

        public virtual List<FileInformation> Read(string path)
        {
            var files = _directoryImpl.ReadDirectory(path);
            foreach (var file in files)
            {
                var fileInfomation = _fileInfoFactory.Create(file);
                _files.Add(fileInfomation);
            }
            return _files;
        }


        public FileReader()
        {
        }
    }
}