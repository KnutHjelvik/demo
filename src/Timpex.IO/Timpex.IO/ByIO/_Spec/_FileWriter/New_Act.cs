using Rhino.Mocks;

namespace Timpex.IO.ByIO._Spec._FileWriter
{
    abstract class New_Act : Base_Act
    {
        protected FileWriter Sut;
        protected FileImpl FileImpl = MockRepository.GenerateMock<FileImpl>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FileWriter(FileImpl);
        }
    }


}