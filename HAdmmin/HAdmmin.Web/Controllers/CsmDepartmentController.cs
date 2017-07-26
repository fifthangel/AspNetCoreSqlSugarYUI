using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HAdmin.Domain.Interface;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HAdmmin.Web.Controllers
{
    public class CsmDepartGroupController : Controller
    {
        private ICsmDepartGroupService CsmDepartGroupService { get; set; }

        public CsmDepartGroupController(ICsmDepartGroupService csmDepartGroupService)
        {
            CsmDepartGroupService = csmDepartGroupService;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var dic = new Dictionary<string, object>();

            dic.Add("PageIndex",1);
            dic.Add("PageSize", 5);

            var list = CsmDepartGroupService.GetList(dic);
            return View(list);
        }
 
    }
}
