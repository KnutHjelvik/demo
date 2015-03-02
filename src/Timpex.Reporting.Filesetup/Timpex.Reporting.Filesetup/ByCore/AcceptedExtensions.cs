using System;
using System.Collections.Generic;

namespace Timpex.Reporting.Filesetup.ByCore
{
    public class AcceptedExtensions
    {
        private Dictionary<string,string> Extensions = new Dictionary<string, string>(); 

        public static Func<AcceptedExtensions> New = () => new AcceptedExtensions();

        public virtual void init(params string[] strings  )
        {
            foreach (var ext in strings)
            {
                Extensions.Add(ext,ext);
            }
        }

        public virtual string Get(string ext)
        {
            if(Extensions.ContainsKey(ext))
                return Extensions[ext];
            return null;
        }
    }
}