using System;
using System.Diagnostics;

namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    public class ProcessImpl
    {
        public static Func<ProcessImpl> New = () => new ProcessImpl ();

        public virtual void Open(string path)
        {
            Process.Start(path);
        } 
    }
}