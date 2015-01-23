using System;

namespace Timpex.IO.ByIO
{
    public class FileReader
    {
        private FileImpl _fileImpl = new FileImpl();
        public static Func<FileReader> New = () => new FileReader();

        public FileReader(FileImpl fileImpl)
        {
            _fileImpl = fileImpl;
        }

        public virtual string[] ReadAllLines(string path)
        {
            return _fileImpl.ReadAllLines(path);
        }

        public FileReader()
        {
        }
    }
}