using Timpex.Reporting.Filesetup.ByCore;
using Timpex.Reporting.Filesetup.ByCore.IO;

namespace Timpex.Reporting.Filesetup
{
    public class StartpointInformation:StartPoint
    {
        private ConsoleImpl _consoleImpl = ConsoleImpl.New();

        public StartpointInformation(ConsoleImpl consoleImpl)
        {
            _consoleImpl = consoleImpl;
        }

        public void Start()
        {
            _consoleImpl.Info("       sql  [Copies and merges all Reporting scripts]");
            _consoleImpl.Info("       deployment  [copies deployment files]");
            _consoleImpl.Info("       bat_ssis  [Copies integration batch files]");
            _consoleImpl.Info("       integration  [Copies integration package files]");
            _consoleImpl.Info("       datasources  [Copies datasourcefiles files]");
            _consoleImpl.Info("       datasets  [Copies dataset files]");
            _consoleImpl.Info("       reports_nor_utv  [Copies norwegian extended and standard reports]");
            _consoleImpl.Info("       reports_eng_utv  [Copies english extended and standard reports]");
            _consoleImpl.Info("       reports_nor  [Copies norwegian standard reports]");
            _consoleImpl.Info("       reports_eng  [Copies english standard reports]");
            _consoleImpl.Info("       nor_std  [Creates a complete package with norwegian standard reports and compresses it]");
            _consoleImpl.Info("       nor_utv  [Creates a complete package with norwegian extended reports and compresses it]");
            _consoleImpl.Info("       eng_std  [Creates a complete package with english standard reports and compresses it]");
            _consoleImpl.Info("       eng_utv  [Creates a complete package with english extended reports and compresses it]");
            _consoleImpl.Info("       ssis  [Creates a complete package with all ssis files]");
            _consoleImpl.Info("       reporting  [copies all reports]");
            _consoleImpl.Info("       all  [Creates a complete package]");
        }

        public StartpointInformation()
        {
        }
    }
}