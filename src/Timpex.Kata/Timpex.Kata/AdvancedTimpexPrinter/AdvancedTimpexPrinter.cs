using System;

namespace Timpex.Kata.AdvancedTimpexPrinter
{

    public class TimpexAdvancedPrinter
    {
        private int _counter;
        private int _timCounter;
        private int _pexCounter;
        private int _timpexCounter;

        public String Print()
        {
            _counter++;
            if (IsTim(_counter) && IsPex(_counter))
                return PrintTimpex();
            if (IsTim(_counter))
                return PrintTim();
            if (IsPex(_counter))
                return PrintPex();
            return _counter.ToString();
        }

        private string PrintTimpex()
        {
            _timpexCounter++;
            if (_timpexCounter == 1)
                return "timpex";
            if (IsTim(_timpexCounter))
                return "timpex tim";
            if (IsPex(_timpexCounter))
                return "timpex pex";
            return "timpex " + _timpexCounter;
        }

        private string PrintTim()
        {
            _timCounter++;
            if (_timCounter == 1)
                return "tim";
            if (IsTim(_timCounter))
                return "tim tim";
            if (IsPex(_timCounter))
                return "tim pex";
            return "tim " + _timCounter;
        }

        private string PrintPex()
        {
            _pexCounter++;
            if (_pexCounter == 1)
                return "pex";
            if (IsTim(_pexCounter))
                return "pex tim";
            if (IsPex(_pexCounter))
                return "pex pex";
            return "pex " + _pexCounter;
        }

        private bool IsPex(int counter)
        {
            return counter % 5 == 0;
        }

        private bool IsTim(int counter)
        {
            return counter % 3 == 0;
        }
    }
}
