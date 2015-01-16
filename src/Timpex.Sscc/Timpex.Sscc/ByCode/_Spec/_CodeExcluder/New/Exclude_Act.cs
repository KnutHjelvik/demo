using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._CodeExcluder.New
{
    abstract class Exclude_Act : New_Act
    {
       
        protected static Code CodeToExclude = MockRepository.GenerateMock<Code>();
        protected static Code CodeToInclude = MockRepository.GenerateMock<Code>();
        protected List<Code> UnhandledList = new List<Code>() { CodeToInclude,CodeToExclude };
        protected List<Code> Expected = new List<Code>(){CodeToInclude};
        protected List<Code> Returned;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            StubPredicate();
        }


        private void StubPredicate()
        {
            SsccPredicate.Stub(x => x.Matches(CodeToInclude)).Return(true);
            SsccPredicate.Stub(x => x.Matches(CodeToExclude)).Return(false);
        }


        protected override void Act()
        {
            Returned = Sut.Exclude(UnhandledList);
        }
    }


}