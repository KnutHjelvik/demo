using System;
using Timpex.Reporting.Filesetup.ByCore.IO;
using Timpex.Reporting.Filesetup.ByCore.Reading.Excluder;

namespace Timpex.Reporting.Filesetup.ByCore
{
    public class FileTransferExecuter
    {
        private FileExcluder _readAndExclude = FileExcluder.New();
        private Copier _copier = Copier.New();
        private ConsoleImpl _consoleImpl = ConsoleImpl.New();

        public static Func<FileTransferExecuter> New = () => new FileTransferExecuter();

        public FileTransferExecuter(FileExcluder fileExcluder, Copier copier,ConsoleImpl consoleImpl)
        {
            _readAndExclude = fileExcluder;
            _copier = copier;
            _consoleImpl = consoleImpl;
        }

        public virtual void Execute(TransferInformation transferInformation, AcceptedExtensions acceptedExtensions,AcceptedPrefix acceptedPrefix)
        {
            var destination = transferInformation.Destination;
            var sourceDir = transferInformation.Source;
            var files = _readAndExclude.ReadAndExclude(acceptedExtensions,acceptedPrefix,sourceDir);
            _copier.Copy(files,destination);
            var info = String.Format("Files copied from location {0} to location {1}", sourceDir, destination);
            _consoleImpl.Write(info);
        }

        public virtual void Execute(TransferInformation transferInformation, AcceptedExtensions acceptedExtensions)
        {
            var destination = transferInformation.Destination;
            var sourceDir = transferInformation.Source;
            var files = _readAndExclude.ReadAndExclude(acceptedExtensions, sourceDir);
            _copier.Copy(files, destination);
            var info = String.Format("Files copied from location {0} to location {1}", sourceDir, destination);
            _consoleImpl.Write(info);
        }

        public FileTransferExecuter()
        {
        }
    }
}