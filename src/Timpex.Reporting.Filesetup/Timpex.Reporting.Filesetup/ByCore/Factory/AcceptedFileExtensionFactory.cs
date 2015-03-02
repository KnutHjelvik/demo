using System;

namespace Timpex.Reporting.Filesetup.ByCore.Factory
{
    public class AcceptedFileExtensionFactory
    {
        public static Func<AcceptedFileExtensionFactory> New = () => new AcceptedFileExtensionFactory();


        public virtual AcceptedExtensions Create(params string[] extensions)
        {
            var acceptedExtensions = AcceptedExtensions.New();
            acceptedExtensions.init(extensions);
            return acceptedExtensions;
        }

        public AcceptedFileExtensionFactory()
        {
        }
    }
}