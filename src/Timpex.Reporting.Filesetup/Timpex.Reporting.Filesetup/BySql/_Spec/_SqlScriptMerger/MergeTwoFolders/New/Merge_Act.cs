using System.Collections.Generic;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.BySql._Spec._SqlScriptMerger.MergeTwoFolders.New
{
    abstract class Merge_Act : New_Act
    {
        protected List<FileInformation> Files1 = new List<FileInformation>();
        protected List<FileInformation> Files2 = new List<FileInformation>();
        protected string Source1 = "source1";
        protected string Source2 = "source2";
        protected string Destination = "destination";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FileReader.Stub(x => x.Read(Source1)).Return(Files1);
            FileReader.Stub(x => x.Read(Source2)).Return(Files2);
        }

        protected override void Act()
        {
           Sut.Merge(Source1,Source2,Destination);
        }
    }


}