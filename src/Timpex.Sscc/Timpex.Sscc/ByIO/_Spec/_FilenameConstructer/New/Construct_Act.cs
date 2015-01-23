using Rhino.Mocks;

namespace Timpex.Sscc.ByIO._Spec._FilenameConstructer.New
{
    abstract class Construct_Act : New_Act
    {
        protected string Returned;
        private const string Prefix = "prefix_";
        private const string Contetnts = "contents";
        private const string Extension = ".ext";
        protected const string Expected = Prefix + Contetnts + Extension;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
            FilePrefix.Stub(x => x.Get()).Return(Prefix);
            FileExtension.Stub(x => x.Get()).Return(Extension);
            FileEpoch.Stub(x => x.Get()).Return(Contetnts);
        }

        protected override void Act()
        {
            Returned = Sut.Construct();
        }
    }


}