using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UAT.Models;

namespace UAT.Controllers
{
    public class ModulesController : Controller
    {
        //
        // GET: /Modules/
        public ActionResult Index()
        {
            UATSytemDbEntities Db = new UATSytemDbEntities();
            
            List<Module> Modulelist = Db.Modules.ToList();

            List<ModulesViewModel> ModulesVM = Modulelist.Select(x => new ModulesViewModel { mId = x.mId, Name = x.Name }).ToList();

            return View(ModulesVM);
        }
	}
}