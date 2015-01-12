namespace Timpex.IO.ByReading
{
    public class FileReader
    {
        private FileImpl _fileImpl = new FileImpl();

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