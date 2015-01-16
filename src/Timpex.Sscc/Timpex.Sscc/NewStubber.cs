using System;
using System.Collections.Generic;

namespace Timpex.Sscc
{
    public class NewStubber<TType>
    {
        private readonly Func<TType> _target;
        private Action _executeCore;
        private TType _instance;
        private List<TType> _instances;

        public NewStubber(ref Func<TType> target, TType stubInstance)
        {
            _target = target;
            _instances = new List<TType>();
            _instances.Add(stubInstance);
            _executeCore = FirstTime;
            target = Execute;
        }

        public NewStubber(ref Func<TType> target, params TType[] stubInstances)
        {
            _target = target;
            _instances = new List<TType>();
            _instances.AddRange(stubInstances);
            _executeCore = FirstTime;
            target = Execute;
        }


        private TType Execute()
        {
            _executeCore();
            return _instance;
        }

        private void FirstTime()
        {
            _instance = _instances[0];
            _instances.RemoveAt(0);
            if (_instances.Count == 0)
                _executeCore = SucceedingTimes;
        }

        private void SucceedingTimes()
        {
            _instance = _target.Invoke();
        }
    }
}