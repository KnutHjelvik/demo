using System;
using System.Collections;
using System.Collections.Generic;

namespace Timpex.Sscc.ByCode
{
    public class CodeListWrapper:IEnumerable<Code>
    {
        public  List<Code> _innerList = new List<Code>();

        public static Func<CodeListWrapper> New = () => new CodeListWrapper();

        public CodeListWrapper(List<Code> innerList)
        {
            _innerList = innerList;
        }

        public virtual void Add(Code code)
        {
            _innerList.Add(code);
        }

        public virtual void Exclude(Code code)
        {
            _innerList.Remove(code);
        }

        public virtual Code Get(int index)
        {
            return _innerList[index];
        }

        public virtual IEnumerator<Code> GetEnumerator()
        {
            return _innerList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public CodeListWrapper()
        {
        }
    }
}