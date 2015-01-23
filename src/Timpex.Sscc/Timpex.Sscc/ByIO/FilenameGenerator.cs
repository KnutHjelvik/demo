using System;

namespace Timpex.Sscc.ByIO
{
    public class FilenameGenerator
    {
        private FilenameConstructer _filenameConstructer = FilenameConstructer.New();

        public static Func<FilenameGenerator> New = () => new FilenameGenerator();

        public FilenameGenerator(FilenameConstructer filenameConstructer)
        {
            _filenameConstructer = filenameConstructer;
        }

        public virtual string Generate()
        {
            return _filenameConstructer.Construct();
        }

        public FilenameGenerator()
        {
        }
    }
}