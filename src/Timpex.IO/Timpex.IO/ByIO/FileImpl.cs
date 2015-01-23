using System.IO;

namespace Timpex.IO.ByIO
{
    public class FileImpl
    {

        public virtual string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }

        public virtual void WriteLines(string path, string[] lines)
        {
            File.WriteAllLines(path,lines);
        }
    }
}