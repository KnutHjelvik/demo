using System.Collections.Generic;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Reading._Spec._FileReader.New
{
    abstract class Read_Act : New_Act
    {

        protected string FolderPath = "FolderPath";
        protected static string File1 = "C:\\test\\File1.txt";
        protected static string File2 = "C:\\test\\File2.txt";
        protected static string[] Files = {File1, File2};

        protected static FileInformation FileInfo1 = MockRepository.GenerateMock<FileInformation>();
        protected static FileInformation FileInfo2 = MockRepository.GenerateMock<FileInformation>();

        protected static List<FileInformation> Expected = new List<FileInformation>(){FileInfo1,FileInfo2};
        protected List<FileInformation> Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FolderSettings.Stub(x => x.GetSsis()).Return(FolderPath);
            DirectoryImpl.Stub(x => x.ReadDirectory(FolderPath)).Return(Files);
            FileInfoFactory.Stub(x => x.Create(File1)).Return(FileInfo1);
            FileInfoFactory.Stub(x => x.Create(File2)).Return(FileInfo2);
        }

        protected override void Act()
        {
            Returned = Sut.Read(FolderPath);
        }
    }


}