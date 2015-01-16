using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;

namespace Timpex.Sscc.ByCode._Spec._ReadCodes.New
{
    abstract class ReadAll_Act : New_Act
    {
        protected List<Code> Returned;
        protected List<Code> Expected = new List<Code>();
        protected string Path = "path";
        protected string[] strings = {"text"};

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FileReader.Stub(x => x.ReadAllLines(Path)).Return(strings);
            CodelistFactory.Stub(x => x.SanitizeCodeList(strings.ToList())).Return(Expected);
        }

        protected override void Act()
        {
            Returned = Sut.ReadAll(Path);
        }
    }


}