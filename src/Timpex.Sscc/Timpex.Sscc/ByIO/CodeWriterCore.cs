using System;
using Timpex.IO.ByIO;

namespace Timpex.Sscc.ByIO
{
    public class CodeWriterCore
    {
        private FileWriter _fileWriter = new FileWriter();
        private FilenameGenerator _filenameGenerator = FilenameGenerator.New();

        public static Func<CodeWriterCore> New = () => new CodeWriterCore();

        public CodeWriterCore(FileWriter fileWriter, FilenameGenerator filenameGenerator)
        {
            _fileWriter = fileWriter;
            _filenameGenerator = filenameGenerator;
        }

        public virtual void WriteCodes(string[] codes)
        {
            var name = _filenameGenerator.Generate();
            _fileWriter.WriteAllLines(name,codes);
        }

        public CodeWriterCore()
        {
        }
    }
}