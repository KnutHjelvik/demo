using System;
using System.Collections.Generic;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore
{
    public class Copier
    {
        public static Func<Copier> New = () => new Copier();
        private FileImpl _fileImpl = FileImpl.New();
        private PathImpl _pathImpl = PathImpl.New();

        public Copier(FileImpl fileImpl,PathImpl pathImpl)
        {
            _fileImpl = fileImpl;
            _pathImpl = pathImpl;
        }

        public virtual void Copy(List<FileInformation> files, string destination)
        {
            foreach (var fileInformation in files)
            {
                var sourcePath = fileInformation.Path;
                var name = fileInformation.Name;
                var fullyQualifiedDestionation = _pathImpl.Combine(destination, name);
                _fileImpl.MoveFile(sourcePath, fullyQualifiedDestionation);
            }
        }

        public Copier()
        {
        }
    }
}