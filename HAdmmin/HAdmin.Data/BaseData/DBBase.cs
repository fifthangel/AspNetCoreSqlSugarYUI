using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HAdmin.Data.BaseData
{
    public class DBBase
    {

        public static IConfigurationRoot Configuration { get; set; }

        static DBBase()
        {
            if (Configuration == null)
            {
                var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
                Configuration = builder.Build();
            }
        }


        public static string GetDBConnectionStr(string key)
        {
            var conStr = Configuration.GetConnectionString(key);
            // return SecurityHelper.DecryptDES(conStr);//连接字符串需加密实现
            return conStr;
        }
        /// <summary>
        /// 只读库
        /// </summary>
        /// <returns>string</returns>
        public static string JxReadOnly1ConnectionStr()
        {
            return GetDBConnectionStr("jx.slave.first.1");
        }
        /// <summary>
        /// 读写库
        /// </summary>
        /// <returns>string</returns>
        public static string JxReadWriteConnectionStr()
        {
            return GetDBConnectionStr("jx.master.first.1");
        }
    }
}
