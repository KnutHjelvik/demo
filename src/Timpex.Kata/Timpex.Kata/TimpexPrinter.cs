using System.Diagnostics;

namespace Timpex.Kata
{
    public class TimpexPrinter
    {
        private int _counter;

        public string Print()
        {
            _counter++;
            if (IsTim() & IsPex())
                return "timpex";
            if (IsTim())
                return "tim";
            if (IsPex())
                return "pex";
            return _counter.ToString();
        }

        private bool IsPex()
        {
            return _counter % 5 == 0;
        }

        private bool IsTim()
        {
            return _counter % 3 == 0;
        }
    }
}
