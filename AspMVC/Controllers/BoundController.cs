using AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC.Controllers
{
    public class BoundController : Controller
    {
        // GET: Bound
        public ActionResult Index()
        {
            Emp E = new Emp();
            return View(E);
        }

        public ActionResult Display(Emp A)
        {
            return View(A);
        }

        public ActionResult Index1()
        {
            Emp E = new Emp();
            return View(E);
        }

        [HttpPost]
        public ActionResult Index1(Emp E)
        {
           
            return View("Display",E);
        }
    }
}