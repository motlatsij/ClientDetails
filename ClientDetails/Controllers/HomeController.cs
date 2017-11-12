using ClientDetails.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace ClientDetails.Controllers
{
    public class HomeController : Controller
    {
        private IHelper helper = new Helper();

        public ActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult> GetIdentityTypes()
        {
            var Types = await helper.GetIdentityTypes();
            return Json(Types, JsonRequestBehavior.AllowGet);
        }

        public async Task<ActionResult> Edit(int id)
        {
            var clients = await helper.Edit(id);
            return Json(clients, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Surname,FirstNames,IdentityTypeId,IdentityNumber,DateofBirth")] Clients clients)
        {
            if (ModelState.IsValid)
            {
                await helper.Update(clients);
            }
            return Json(clients);
        }
    }
}