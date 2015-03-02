using System;

namespace Timpex.Sscc.ByIO
{
    public class FilenameConstructer
    {
        private FileExtension _fileExtension = FileExtension.New();
        private CurrentDateString _currentDateString = CurrentDateString.New();
        private FilePrefix _filePrefix = FilePrefix.New();
        private string _constructedResult;

        public static Func<FilenameConstructer> New = () => new FilenameConstructer();

        public FilenameConstructer(FileExtension fileExtension,CurrentDateString currentDateString, FilePrefix filePrefix )
        {
            _fileExtension = fileExtension;
            _currentDateString = currentDateString;
            _filePrefix = filePrefix;
        }

        public virtual string Construct()
        {
            ConstructCore();
            return _constructedResult;
        }

        private void ConstructCore()
        {
            var prefix = _filePrefix.Get();
            var filenamecontets = _currentDateString.Get();
            var extension = _fileExtension.Get();
            _constructedResult = prefix + filenamecontets + extension;
        }

        public FilenameConstructer()
        {
        }
    }
}