using System;

namespace Timpex.Reporting.Filesetup.ByCore.Factory
{
    public class AcceptedFilePrefixFactory
    {
        public static Func<AcceptedFilePrefixFactory> New = () => new AcceptedFilePrefixFactory();


        public virtual AcceptedPrefix Create(params string[] prefixes)
        {
            var acceptedPrefix = AcceptedPrefix.New();
            acceptedPrefix.init(prefixes);
            return acceptedPrefix;
        }

        public AcceptedFilePrefixFactory()
        {
        }
    }
}