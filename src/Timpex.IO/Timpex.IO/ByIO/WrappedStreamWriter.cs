using System.IO;

namespace Timpex.IO.ByIO
{
    public class WrappedStreamWriter
    {
        private StreamWriter _innerWriter;
        private string _path;

        public void Init(string path)
        {
            _path = path;
            NegotiateInit();
        }

        public void WriteLine(string line)
        {
            _innerWriter.WriteLine(line);
        }

        public void Close()
        {
            _innerWriter.Close();
        }

        private void NegotiateInit()
        {
            if (_innerWriter == null)
            {
                _innerWriter = new StreamWriter(_path);
            }
        }
    }
}