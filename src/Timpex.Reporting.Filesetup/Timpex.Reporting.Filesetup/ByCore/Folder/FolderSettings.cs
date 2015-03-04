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

        public virtual string GetDeploymentScripts()
        {
            return get("C:/devel/Timpex/reporting/Scripts/Report deployment script/");
        }

        public virtual string GetDatasources()
        {
            return get("C:/devel/Timpex/reporting/Reports/TimpexRapporter/");
        }

        public virtual string GetSqlBatch()
        {
            return get("C:/devel/Timpex/reporting/SQL/SQL Update Script/CMD/");
        }

        public virtual string GetSqlMaster()
        {
            return get("C:/devel/Timpex/reporting/SQL/SQL Update Script/Reporting.Master/");
        }

        public virtual string GetSqlUpdates()
        {
            return get("C:/devel/Timpex/reporting/SQL/SQL Update Script/Reporting.Updates/");
        }

        private string get(string folder)
        {
            return folder;
        }
    }
}
