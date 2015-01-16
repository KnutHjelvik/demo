using Timpex.IO;

namespace Timpex.Sscc.ByPredicate._Spec._EmptyPredicate
{
    abstract class New_Act : Base_Act
    {
        protected EmptyPredicate Sut;

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut = new EmptyPredicate();
        }
    }


}