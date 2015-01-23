namespace Timpex.IO.ByIO._Spec._FileWriter.New
{
    abstract class WriteAllLines_Act : New_Act
    {
        protected string[] lines = { "line","line"};

        protected const string Path = "Path";

        protected override void Arrange()
        {
            base.Arrange();
            base.Act();
        }

        protected override void Act()
        {
            Sut.WriteAllLines(Path, lines);
        }
    }


}