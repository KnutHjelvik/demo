using System;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Reading;

namespace Timpex.Reporting.Filesetup.BySql
{
    public class SqlScriptMerger
    {
        private FileReader _fileReader = FileReader.New();
        private FileMerger _innerMerger = FileMerger.New();

        public static Func<SqlScriptMerger> New = () => new SqlScriptMerger();

        public SqlScriptMerger(FileMerger fileMerger,FileReader fileReader)
        {
            _fileReader = fileReader;
            _innerMerger = fileMerger;
        }

        public virtual void Merge(string source1, string source2, string destination)
        {
            var sourceFiles1 = _fileReader.Read(source1);
            var sourceFiles2 = _fileReader.Read(source2);
            _innerMerger.Merge(sourceFiles1,sourceFiles2,destination);
        }

        public virtual void Merge(string source1, string destination)
        {
            var sourceFiles1 = _fileReader.Read(source1);
            _innerMerger.Merge(sourceFiles1, destination);
        }


        public SqlScriptMerger()
        {
        }
    }
}