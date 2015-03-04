using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore
{
    public class FileMerger
    {

        public static Func<FileMerger> New = () => new FileMerger();
        private ConsoleImpl _consoleImpl = ConsoleImpl.New();

        public virtual void Merge(List<FileInformation> one, List<FileInformation> two, string destination)
        {
            var merged = one.Concat(two);
            CoreMerge(destination, merged);
        }

        private void CoreMerge(string destination, IEnumerable<FileInformation> merged)
        {
            const int chunkSize = 2*1024; // 2KB
            using (var output = File.Create(destination))
            {
                foreach (var file in merged)
                {
                    _consoleImpl.Write(String.Format("Merging file {0} to destination file {1}", file.Name, destination));
                    using (var input = File.OpenRead(file.Path))
                    {
                        var buffer = new byte[chunkSize];
                        int bytesRead;
                        while ((bytesRead = input.Read(buffer, 0, buffer.Length)) > 0)
                        {
                            output.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }
            _consoleImpl.Write(String.Format("Done merging {0}", destination));
        }

        public virtual void Merge(List<FileInformation> sourceFiles1, string destination)
        {
            CoreMerge(destination,sourceFiles1);
        }
    }
}