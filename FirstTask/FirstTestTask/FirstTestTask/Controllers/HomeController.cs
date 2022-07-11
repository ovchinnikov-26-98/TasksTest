using FirstTestTask.Interface;
using FirstTestTask.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstTestTask.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }
        public ActionResult Index(int pg = 1, int pz =50)
        {
            var elements = unitOfWork.randomElementRepository.FindaAll().ToList();
            var aaaaa = pg;
            int pageSize = pz;
            if (pg < 1 ) pg = 1;
            int recsCount = elements.Count();
            var pager = new Pager(recsCount, pg, pageSize);
            int recSkip = (pg - 1) * pageSize;
            var data = elements.Skip(recSkip).Take(pager.PageSize).ToList();
            this.ViewBag.Pager = pager;
            return View(data);
        }

       
    }
}