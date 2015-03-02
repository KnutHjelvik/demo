using System;
using System.Collections.Generic;
using System.IO;

namespace Timpex.Reporting.Filesetup.ByCore.IO
{
    public class DirectoryImpl
    {
        public static Func<DirectoryImpl> New = () => new DirectoryImpl();

        public virtual IEnumerable<string> ReadDirectory(string path)
        {
            return Directory.EnumerateFiles(path);
        }

        public virtual void CreateRootDirectory()
        {
            Directory.CreateDirectory("./Reporting");
        }

        public virtual string CreateSsisDirectory()
        {
            var path = "C:/Devel/TRDeployment/Reporting/SSIS/";
            Directory.CreateDirectory(path);
            return path;
        }

        public virtual string CreateReportsDirectory()
        {
            var path = "C:/Devel/TRDeployment/Reporting/Reports/";
            Directory.CreateDirectory(path);
            return path;
        }

        public virtual string CreateReportEnglishDirectory()
        {
            var path = "C:/Devel/TRDeployment/Reporting/Reports_ENG/";
            Directory.CreateDirectory(path);
            return path;
        }

        public virtual string CreateDataSourceDirectory()
        {
            var path = "C:/Devel/TRDeployment/Reporting/DataSource/";
            Directory.CreateDirectory(path);
            return path;
        }

        public virtual string CreateDataSetDirectory()
        {
            var path = "C:/Devel/TRDeployment/Reporting/DataSet/";
            Directory.CreateDirectory(path);
            return path;
        }

        public virtual void RemoveRootDirectory()
        {
            Directory.Delete("./Reporting",true);
        }
    }
}