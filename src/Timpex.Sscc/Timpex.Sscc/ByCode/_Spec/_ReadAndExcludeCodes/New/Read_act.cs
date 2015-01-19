using System.Collections.Generic;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._ReadAndExcludeCodes.New
{
    abstract class Read_Act : New_Act
    {

        protected static Code code1 = MockRepository.GenerateMock<Code>();
        protected static Code code2 = MockRepository.GenerateMock<Code>();
        protected static Code code3 = MockRepository.GenerateMock<Code>();
        protected static Code code4 = MockRepository.GenerateMock<Code>();

        protected List<Code> Expected = new List<Code>{code1,code2};
        protected List<Code> UnHandledList = new List<Code>{code1, code2, code3, code4};
        protected List<Code> Returned;
        protected string path = "";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            ReadCodesCore.Stub(x => x.ReadAll(path)).Return(UnHandledList);
            CodeExcluder.Stub(x => x.Exclude(UnHandledList)).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.Read(path);
        }
    }


}