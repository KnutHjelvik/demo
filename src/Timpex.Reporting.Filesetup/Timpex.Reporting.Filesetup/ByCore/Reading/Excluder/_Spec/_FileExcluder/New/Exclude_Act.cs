using System.Collections.Generic;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder._Spec._FileExcluder.New
{
    abstract class Exclude_Act : New_Act
    {
        protected AcceptedExtensions AcceptedExtensions = MockRepository.GenerateMock<AcceptedExtensions>();
        protected static FileInformation FileInformation1 = MockRepository.GenerateMock<FileInformation>();
        protected static FileInformation FileInformation2 = MockRepository.GenerateMock<FileInformation>();
        protected static FileInformation FileInformation3 = MockRepository.GenerateMock<FileInformation>();

        protected List<FileInformation> FilesRead = new List<FileInformation>() { FileInformation1, FileInformation2, FileInformation3 };

        protected List<FileInformation> Expected = new List<FileInformation>() { FileInformation1, FileInformation3 };

        protected AcceptedPrefix AcceptedPrefix = MockRepository.GenerateMock<AcceptedPrefix>();

        protected List<FileInformation> Returned;

        protected string Path = "Path";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FileReader.Stub(x => x.Read(Path)).Return(FilesRead);
            FileInformation1.Stub(x => x.Extension).Return(".dtsx");
            FileInformation2.Stub(x => x.Extension).Return(".ddddd");
            FileInformation3.Stub(x => x.Extension).Return(".txt");
            AcceptedExtensions.Stub(x => x.Get(FileInformation1.Extension)).Return(FileInformation1.Extension);
            AcceptedExtensions.Stub(x => x.Get(FileInformation2.Extension)).Return(null);
            AcceptedExtensions.Stub(x => x.Get(FileInformation3.Extension)).Return(FileInformation3.Extension);
            Excluder.Stub(x => x.Exclude(Expected, AcceptedPrefix)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.ReadAndExclude(AcceptedExtensions,null,Path);
        }
    }


}