using Rhino.Mocks;

namespace Timpex.IO.ByReading._Spec._FileReader.New
{
    abstract class ReadAllLines_Act : New_Act
    {
        protected string[] Expected = { "line","line"};
        protected string[] Returned;

        private const string Path = "Path";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FileImpl.Stub(x => x.ReadAllLines(Path)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.ReadAllLines(Path);
        }
    }


}