using System;
using System.Collections.Generic;
using System.Text;
using HAdmin.Domain.Interface;
using HAdmin.Entity.CSM;
using HAdmin.Data.Interface;
using Sakura.AspNetCore;

namespace HAdmin.Domain.Implement
{
    public class CsmDepartGroupService : ICsmDepartGroupService
    {
        private ICsmDepartGroupProvider CsmDepartGroupProvider { get; set; }

        public CsmDepartGroupService(ICsmDepartGroupProvider csmDepartGroupProvider)
        {
            this.CsmDepartGroupProvider = csmDepartGroupProvider;

        }


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
            return CsmDepartGroupProvider.GetList(condition, obj);
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
