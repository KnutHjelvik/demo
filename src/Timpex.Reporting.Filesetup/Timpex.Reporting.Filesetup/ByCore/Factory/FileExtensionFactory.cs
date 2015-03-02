using System;

namespace Timpex.Reporting.Filesetup.ByCore.Factory
{
    public class FileExtensionFactory
    {
        private FilenameFactory _innerFactory = FilenameFactory.New();
        public static Func<FileExtensionFactory> New = () => new FileExtensionFactory();

        public FileExtensionFactory(FilenameFactory filenameFactory)
        {
            _innerFactory = filenameFactory;
        }

        public virtual string Create(string fqPath)
        {
            var name = _innerFactory.Create(fqPath);
            var dot = name.LastIndexOf(".");
            return name.Substring(dot);
        }

        public FileExtensionFactory()
        {
        }
    }
}