using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.Reading;

namespace Timpex.Reporting.Filesetup.BySql._Spec._SqlScriptMerger.MergeTwoFolders
{
    abstract class New_Act : Base_Act
    {
        protected SqlScriptMerger Sut;
        protected FileReader FileReader = MockRepository.GenerateMock<FileReader>();
        protected FileMerger FileMerger = MockRepository.GenerateMock<FileMerger>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
           Sut = new SqlScriptMerger(FileMerger,FileReader); 
        }
    }


}