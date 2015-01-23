using System;

namespace Timpex.Sscc.ByIO
{
    public class FilePrefix
    {

        public static Func<FilePrefix> New = () => new FilePrefix();

        public virtual string Get()
        {
            return "valid_sscc_";
        } 
    }
}