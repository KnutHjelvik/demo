using System;

namespace Timpex.Reporting.Filesetup.ByCore.Folder
{
    public class FolderSettings
    {
        public static Func<FolderSettings> New = () => new FolderSettings();

        public virtual string GetSsis()
        {
            return get("C:/devel/Timpex/reporting/SSIS/TimpexIntegrationProject/");
        }

        public virtual string GetNorwegianReports()
        {
            return get("C:/devel/Timpex/reporting/Reports/TimpexRapporter/");
        }

        public virtual string GetEnglishReports()
        {
            return get("C:/devel/Timpex/reporting/Reports/TimpexRapporterEngelsk/");
        }

        public virtual string GetDatasets()
        {
            return get("C:/devel/Timpex/reporting/Reports/TimpexRapporter/");
        }

        public virtual string GetDatasources()
        {
            return get("C:/devel/Timpex/reporting/Reports/TimpexRapporter/");
        }

        private string get(string folder)
        {
            return folder;
        }
    }
}
