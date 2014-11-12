using System.Diagnostics;

namespace Timpex.Kata
{
    public class TimpexPrinter
    {
        private int _counter;

        public string Print()
        {
            _counter++;
            if (_counter % 3 == 0 & _counter % 5 == 0)
                return "timpex";
            if (_counter % 3 == 0)
                return "tim";
            if (_counter % 5 == 0)
                return "pex";
            return _counter.ToString();
        }
    }
}
