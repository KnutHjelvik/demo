namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    public class FileInformation
    {
        public virtual string Extension { get; set; }
        public virtual string Name { get; set; }
        public virtual string Path { get; set; }
        public virtual byte[] Contents { get; set; }
    }
}