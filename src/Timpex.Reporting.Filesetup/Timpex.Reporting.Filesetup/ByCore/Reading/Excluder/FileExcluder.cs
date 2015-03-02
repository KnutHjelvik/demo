using System;
using System.Collections.Generic;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder
{
    public class FileExcluder
    {
        private FileReader _innerReader = FileReader.New();
        private ExcludeFilesByPrefix _innerExcluder = ExcludeFilesByPrefix.New();
        private List<FileInformation> _list = new List<FileInformation>();

        public static Func<FileExcluder> New = () => new FileExcluder();

        public FileExcluder(FileReader innerReader,ExcludeFilesByPrefix excludeFilesByPrefix)
        {
            _innerReader = innerReader;
            _innerExcluder = excludeFilesByPrefix;
        }

        public virtual List<FileInformation> ReadAndExclude(AcceptedExtensions acceptedExtensions,AcceptedPrefix acceptedPrefix,string path)
        {
            var files = _innerReader.Read(path);
            foreach (var fileInformation in files)
            {
                if(acceptedExtensions.Get(fileInformation.Extension)!=null)
                    _list.Add(fileInformation);
            }
            return _innerExcluder.Exclude(files,acceptedPrefix);
        }

        public virtual List<FileInformation> ReadAndExclude(AcceptedExtensions acceptedExtensions, string path)
        {
            var files = _innerReader.Read(path);
            foreach (var fileInformation in files)
            {
                if (acceptedExtensions.Get(fileInformation.Extension) != null)
                    _list.Add(fileInformation);
            }
            return _list;
        }

        public FileExcluder()
        {
        }
    }
}