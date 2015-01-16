using System.Collections.Generic;
using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeListFactory.New
{
    abstract class CreateCodeList_Act : New_Act
    {
        protected static Code code1 = MockRepository.GenerateMock<Code>();
        protected static Code code2 = MockRepository.GenerateMock<Code>();
        protected static Code code3 = MockRepository.GenerateMock<Code>();
        protected Code code4 = MockRepository.GenerateMock<Code>();

        protected const string codeStr1 = "code1";
        protected const string codeStr2 = "code2";
        protected const string codeStr3 = "code3";
        protected const string codeStr4 = "";



        protected List<string> Codes = new List<string> { codeStr1, codeStr2, codeStr3,codeStr4 };
        protected List<Code> Expected = new List<Code>() {code1, code2, code3};

        protected List<Code> Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubCodeFactory();
            StubEmptyPredicate();
        }

        private void StubEmptyPredicate()
        {
            EmptyPredicate.Stub(x => x.IsEmpty(codeStr1)).Return(false);
            EmptyPredicate.Stub(x => x.IsEmpty(codeStr2)).Return(false);
            EmptyPredicate.Stub(x => x.IsEmpty(codeStr3)).Return(false);
            EmptyPredicate.Stub(x => x.IsEmpty(codeStr4)).Return(true);
        }

        private void StubCodeFactory()
        {
            CodeFactory.Stub(x => x.CreateCode(codeStr1)).Return(code1);
            CodeFactory.Stub(x => x.CreateCode(codeStr2)).Return(code2);
            CodeFactory.Stub(x => x.CreateCode(codeStr3)).Return(code3);
        }

        protected override void Act()
        {
            Returned = Sut.SanitizeCodeList(Codes);
        }

    }


}