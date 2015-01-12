using Rhino.Mocks;

namespace Timpex.IO.ByReading._Spec._FileReader
{
    abstract class New_Act : Base_Act
    {
        protected FileReader Sut;
        protected FileImpl FileImpl = MockRepository.GenerateMock<FileImpl>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileReader(FileImpl);
        }
    }


}