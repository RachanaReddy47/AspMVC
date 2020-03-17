using AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC.Controllers
{
    public class UnboundController : Controller
    {
        // GET: Unbound
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowData()
        {
            Emp E = new Emp();
            E.Empno =int.Parse(Request.Form["txtEmpno"]);
            E.Ename = Request.Form["txtEname"];
            E.Salary =double.Parse(Request.Form["txtSalary"]);
            return View(E);
        }

    }
}