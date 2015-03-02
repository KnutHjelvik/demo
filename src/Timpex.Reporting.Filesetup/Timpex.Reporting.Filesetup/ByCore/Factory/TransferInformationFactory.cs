using System;

namespace Timpex.Reporting.Filesetup.ByCore.Factory
{
    public class TransferInformationFactory
    {
        public static Func<TransferInformationFactory> New = () => new TransferInformationFactory();

        public virtual TransferInformation Create(string source, string destination)
        {
            var transferInformation = TransferInformation.New();
            transferInformation.Destination = destination;
            transferInformation.Source = source;
            return transferInformation;
        }

        public TransferInformationFactory()
        {
        }
    }
}