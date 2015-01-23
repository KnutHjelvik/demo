using System;
using Rhino.Mocks;
using Timpex.Sscc.ByPredicate;

namespace Timpex.Sscc.ByDto._Spec._CodeDtoStringCreater.New
{
    abstract class Create_Act : New_Act
    {
        
        protected static string NewLine = Environment.NewLine;
        protected static string ApplicationIdentifier = "A";
        protected static string CountryCode = "B";
        protected static string Identifier = "C";
        protected static string Supplier = "D";
        protected static string Serial = "E";
        private CodeDto Dto = MockRepository.GenerateMock<CodeDto>();


        protected string Expected;
        protected string Returned;

        private  void SetupExpected()
        {
           Expected = ApplicationIdentifier + NewLine + CountryCode + NewLine + Identifier +NewLine + Supplier + NewLine + Serial + NewLine;
        }

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            SetupExpected();
            Dto.Stub(x => x.CountryCode).Return(CountryCode);
            Dto.Stub(x => x.ApplicationIdentifier).Return(ApplicationIdentifier);
            Dto.Stub(x => x.Identifier).Return(Identifier);
            Dto.Stub(x => x.Serial).Return(Serial);
            Dto.Stub(x => x.SupplierCode).Return(Supplier);
            Strings.Stub(x => x.Concat(ApplicationIdentifier, Identifier, CountryCode, Supplier, Serial)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Create(Dto);
        }
    }


}