using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UAT.Models;

namespace UAT.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/
        public ActionResult Index()
        {
            UATSytemDbEntities Db = new UATSytemDbEntities();

            //Module module = Db.Modules.SingleOrDefault (x=> x.Name=="FICO");

            List<Module> modulelist = Db.Modules.ToList();

            /*   //Code for updating
             * 
            var modulelist1 = Db.Modules.Where (x=> x.mId ==1 && x.Name=="FICO").ToList();
            modulelist1.ForEach(m1 => m1.Name = "FI-CO");
            Db.SaveChanges();
            */

            ModulesViewModel ModulesVM = new ModulesViewModel();

            List<ModulesViewModel> ModulesVMlist = modulelist.Select(x => new ModulesViewModel { mId = x.mId, Name = x.Name }).ToList();

           // ModulesVM.mId = module.mId;
           // ModulesVM.Name = module.Name;
            
            //ViewBag.NameList = list;

            return View(ModulesVMlist);
        }
	}
}