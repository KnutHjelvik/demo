using Rhino.Mocks;

namespace Timpex.Reporting.Filesetup.ByCore.Factory._AcceptedFileExtensionFactory.New
{
    abstract class Create_Act : New_Act
    {
        protected string[] Extensions = {".txt",".dtsx"};
        protected AcceptedExtensions Expected = MockRepository.GenerateMock<AcceptedExtensions>();
        protected AcceptedExtensions Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubNew(ref AcceptedExtensions.New,Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Create(Extensions);
        }
    }


}