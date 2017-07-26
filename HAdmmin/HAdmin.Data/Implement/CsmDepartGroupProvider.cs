using HAdmin.Data.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using HAdmin.Entity.CSM;
using HAdmin.Data.BaseData;
using MySqlSugar;
using Sakura.AspNetCore;
using System.Data.SqlClient;


namespace HAdmin.Data.Implement
{
    public class CsmDepartGroupProvider : ICsmDepartGroupProvider
    {
        public int Create(CsmDepartGroup t, object obj = null)
        {
            throw new NotImplementedException();
        }

        public CsmDepartGroup Get(int pkId, object obj = null)
        {
            throw new NotImplementedException();
        }

        public PagedList<IEnumerable<CsmDepartGroup>, CsmDepartGroup> GetList(Dictionary<string, object> condition, object obj = null)
        {

            using (var db = new SqlSugarClient(DBBase.JxReadOnly1ConnectionStr()))
            {
                var pageSize = Convert.ToInt32(condition["PageSize"]);
                var pageIndex = Convert.ToInt32(condition["PageIndex"]);
                var list = db.Queryable<CsmDepartGroup>("csm_depart_group");
                foreach (var item in condition)
                {
                    list = list.Where(p => 1 == 1);//可拼接where条件
                }
                var result = list.OrderBy(p => p.Id)
                   .ToList()
                   .ToPagedList(pageSize, pageIndex);
                return result;
            }

        }

        public bool Modeify(CsmDepartGroup t, object obj = null)
        {
            throw new NotImplementedException();
        }

        public bool Remove(CsmDepartGroup t, object obj = null)
        {
            throw new NotImplementedException();
        }
    }
}
