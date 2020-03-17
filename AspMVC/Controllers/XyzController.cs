using AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC.Controllers
{
    public class XyzController : Controller
    {
        // GET: Xyz
        public ActionResult Index()
        {
            ViewBag.str = "My First MVC Project";
            ViewData["str1"] = "started";
            TempData["str2"] = "Today";
            return View();
        }

        public ActionResult SendObject()
        {
            Emp E = new Emp();
            E.Empno = 100;
            E.Ename = "Rachana";
            E.Salary = 20000;
            return View(E);
        }

        public ActionResult SendObjects()
        {
            List<Emp> L = new List<Emp>();

            Emp E = new Emp();
            E.Empno = 1;
            E.Ename = "abc";
            E.Salary = 10000;
            L.Add(E);

            E = new Emp();
            E.Empno = 2;
            E.Ename = "pqr";
            E.Salary = 20000;
            L.Add(E);

            return View(L);
        }

        public ActionResult SendObjectVB()
        {
            Emp E = new Emp();
            E.Empno = 1;
            E.Ename = "abc";
            E.Salary = 1000;
            ViewBag.xyz = E;
            ViewData["ofc"] = E;
            return View();
        }

        public ActionResult SendObjectsVB()
        {
            List<Emp> L = new List<Emp>();
            Emp E = new Emp();
            E.Empno = 1;
            E.Ename = "abc";
            E.Salary = 1000;
            L.Add(E);

            E = new Emp();
            E.Empno = 2;
            E.Ename = "bbb";
            E.Salary = 1000;
            L.Add(E);
            ViewBag.xyz = L;
            ViewData["xyz"] = L;
            return View();

        }
    }
}