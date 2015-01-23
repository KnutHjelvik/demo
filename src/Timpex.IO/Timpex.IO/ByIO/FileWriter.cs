namespace Timpex.IO.ByIO
{
    public class FileWriter
    {
        private FileImpl _fileImpl = new FileImpl();

        public FileWriter(FileImpl fileImpl)
        {
            _fileImpl = fileImpl;
        }

        public virtual void WriteAllLines(string path, string[] lines)
        {
            _fileImpl.WriteLines(path,lines);
        }

        public FileWriter()
        {
        }
    }
}