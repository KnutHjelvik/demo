using System.IO;

namespace Timpex.IO.ByReading
{
    public class FileImpl
    {

        public virtual string[] ReadAllLines(string path)
        {
            return File.ReadAllLines(path);
        }
    }
}