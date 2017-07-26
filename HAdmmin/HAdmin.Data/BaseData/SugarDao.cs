using System;
using System.Collections.Generic;
using System.Text;
 

namespace HAdmin.Data.BaseData
{
   public  class SugarDao
    {
        //禁止实例化
        private SugarDao()
        {

        }

        /// <summary>
        /// 获取实例
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        //public static ISqlSugarClient GetInstance(DbType type, string SqlConnString)
        //{
        //    ISqlSugarClient db = null;
        //    db = DbRepository.GetInstance(type, SqlConnString);
        //    db.IsEnableLogEvent = true;
        //    db.LogEventStarting = (sql, pars) =>
        //    {
        //        PrintSql(sql, pars);
        //    };
        //    return db;
        //}
    }
}
