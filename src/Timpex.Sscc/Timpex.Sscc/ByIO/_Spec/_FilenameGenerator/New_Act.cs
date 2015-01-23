using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._FilenameGenerator
{
    abstract class New_Act : Base_Act
    {
        protected FilenameGenerator Sut;
        protected FilenameConstructer FilenameConstructer = MockRepository.GenerateMock<FilenameConstructer>();

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new FilenameGenerator(FilenameConstructer);
        }
    }


}   