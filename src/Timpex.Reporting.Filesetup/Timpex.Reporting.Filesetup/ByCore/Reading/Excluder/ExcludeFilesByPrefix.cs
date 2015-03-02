using System;
using System.Collections.Generic;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder
{
    public class ExcludeFilesByPrefix
    {
        public static Func<ExcludeFilesByPrefix> New = () => new ExcludeFilesByPrefix();

        private List<FileInformation> _files = new List<FileInformation>(); 

        public virtual List<FileInformation> Exclude(List<FileInformation> files, AcceptedPrefix acceptedPrefix)
        {
            ExcludeCore(files, acceptedPrefix);
            return _files;
        }

        private void ExcludeCore(List<FileInformation> files, AcceptedPrefix acceptedPrefix)
        {
            var enumerator = acceptedPrefix.GetEnumerable();
            while (enumerator.MoveNext())
            {
                var key = enumerator.Current.Key;
                foreach (var fileInformation in files)
                {
                    if (fileInformation.Name.Contains(key))
                        _files.Add(fileInformation);
                }
            }
        }

        public ExcludeFilesByPrefix()
        {
        }
    }
}