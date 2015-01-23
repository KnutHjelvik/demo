using Rhino.Mocks;
using Timpex.Sscc.ByCode;

namespace Timpex.Sscc.ByDto._Spec._CodeToDtoMapper.New
{
    abstract class Map_Act : New_Act
    {

        protected Code UnhandledCode = MockRepository.GenerateMock<Code>();
        protected const string CountryCode = "70";
        protected const string SerialNumber = "1234567891";
        protected const string Supplier = "1234";
        protected const string Identifier = "3";
        protected const string ApplicationIdentifier = "(00)";
        protected CodeDto Expected = MockRepository.GenerateMock<CodeDto>();
        protected CodeDto Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            CodeExtracter.Stub(x => x.ExtractIdentifier()).Return(Identifier);
            CodeExtracter.Stub(x => x.ExtractApplicationIdentifier()).Return(ApplicationIdentifier);
            CodeExtracter.Stub(x => x.ExtractCountryCode()).Return(CountryCode);
            CodeExtracter.Stub(x => x.ExtractSupplier()).Return(Supplier);
            CodeExtracter.Stub(x => x.ExtractSerialNumber()).Return(SerialNumber);
        }

        protected override void Act()
        {
            Returned = Sut.Map(UnhandledCode);
        }
    }


}