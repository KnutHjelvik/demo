using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByIO._Spec._CodeWriterCore.New
{
    abstract class WriteCodes_Act : New_Act
    {
        protected static string code1 = "A";
        protected static string code2 = "B";
        protected string[] Codes = new string[] {code1,code2};
        protected string Filename = "Filename";


        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FilenameGenerator.Stub(x => x.Generate()).Return(Filename);
        }

        protected override void Act()
        {
            Sut.WriteCodes(Codes);
        }
    }


}