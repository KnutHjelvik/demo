using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup.ByCore.Reading.Excluder._Spec._ExcludeFilesByPrefix.New
{
    abstract class Exclude_Act : New_Act
    {
        protected static FileInformation FileInformation1 = MockRepository.GenerateMock<FileInformation>();
        protected static FileInformation FileInformation2 = MockRepository.GenerateMock<FileInformation>();
        protected static FileInformation FileInformation3 = MockRepository.GenerateMock<FileInformation>();
        protected List<FileInformation> Files = new List<FileInformation>() {FileInformation1,FileInformation2,FileInformation3};
        protected AcceptedPrefix AcceptedPrefix = MockRepository.GenerateMock<AcceptedPrefix>();
        protected List<FileInformation> Expected = new List<FileInformation>() {FileInformation2, FileInformation3};
        protected List<FileInformation> Returned;

        protected string[] prefix = {"STD"};

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            var Dicitonary = new Dictionary<string, string>();
            Dicitonary.Add("STD","STD");
            FileInformation2.Stub(x => x.Name).Return("File-K9-STD");
            FileInformation3.Stub(x => x.Name).Return("File-K10-STD");
            FileInformation1.Stub(x => x.Name).Return("File-K10-ST");
            AcceptedPrefix.Stub(x => x.GetEnumerable()).Return(Dicitonary.GetEnumerator());
        }

        protected override void Act()
        {
            Returned = Sut.Exclude(Files, AcceptedPrefix);
        }
    }


}