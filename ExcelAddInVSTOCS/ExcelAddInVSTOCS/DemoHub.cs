using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Office.Tools;
using Microsoft.Office.Tools.Excel;
using Serilog;
using FreeSql;


namespace ExcelAddInVSTOCS
{
    public static class DemoHub
    {
        private static IFreeSql fsql;

        static DemoHub()
        {
            InitLog();
            InitSQL();
        }

        public static IFreeSql FSQL {
            get
            {
                if (fsql is null)
                {
                    InitSQL();
                }
                return fsql;
            } 
        }

        /// <summary>
        /// 初始化日志
        /// </summary>
        private static void InitLog()
        {
            // var sd = Environment.GetEnvironmentVariable("systemdrive");
            var p = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "logs", "demo-.log");
            Log.Logger = new LoggerConfiguration()
               .MinimumLevel.Information()
               .WriteTo.File
               (
                    path: p,
                    rollingInterval: RollingInterval.Day,
                    rollOnFileSizeLimit: true,
                    fileSizeLimitBytes: 2000000,
                    flushToDiskInterval: TimeSpan.FromSeconds(10),
                    outputTemplate: "[{Timestamp:yy-MM-dd HH:mm:ss} {Level:u3}] {Message:lj}{NewLine}{Exception}"
                )
                .CreateLogger();
            Log.Information("日志初始化");
        }

        /// <summary>
        /// 初始化数据库
        /// </summary>
        public static void InitSQL()
        {
            if (fsql is null)
            {
                var p = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "excel-demo.db");
                fsql = new FreeSql.FreeSqlBuilder()
                    .UseConnectionString(DataType.Sqlite, $"Data Source={p}")
                    .UseAutoSyncStructure(true)
                    .Build();
                Log.Information("数据库初始化");
            }
        }
    }
}
