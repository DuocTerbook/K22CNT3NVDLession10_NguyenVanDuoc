using Nvd_lession10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nvd_lession10.Controllers
{
    public class NvdHomeController : Controller
    {
        public ActionResult NvdIndex()
        {
            //Kiểm tra dữ liệu trong session
            if (Session["NvdAccount"] != null)
            {
                var nvdAccount = Session["NvdAccount"] as NvdAccount;
                ViewBag.FullName = nvdAccount.NvdFullName;
            }    
            return View();
        }

        public ActionResult NvdAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NvdContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}