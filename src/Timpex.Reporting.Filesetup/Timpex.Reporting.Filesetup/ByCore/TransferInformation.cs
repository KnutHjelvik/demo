using System;

namespace Timpex.Reporting.Filesetup.ByCore
{
    public class TransferInformation
    {
        public static Func<TransferInformation> New = () => new TransferInformation();

        public virtual string Source { get; set; }
        public virtual string Destination { get; set; }
    }
}