using System;
using System.Collections;
using System.Collections.Generic;

namespace Timpex.Reporting.Filesetup.ByCore
{
    public class AcceptedPrefix
    {
        private Dictionary<string,string> Prefixes = new Dictionary<string, string>();

        public static Func<AcceptedPrefix> New = () => new AcceptedPrefix();

        public virtual void init(params string[] strings  )
        {
            foreach (var prefix in strings)
            {
                Prefixes.Add(prefix, prefix);
            }
        }

        public virtual string Get(string prefix)
        {
            if (Prefixes.ContainsKey(prefix))
                return Prefixes[prefix];
            return null;
        }

        public virtual Dictionary<string, string>.Enumerator GetEnumerable()
        {
            return Prefixes.GetEnumerator();
        } 
    }
}