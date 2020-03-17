using AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC.Controllers
{
    public class RadiobtnController : Controller
    {
        // GET: Radiobtn
        static List<DEPTDATA> List = new List<DEPTDATA>();

        public ActionResult Index()
        {
            ViewBag.D = Radiobtn.getDeptnos();
            //List =Radiobtn.getDeptnos();
            //ViewBag.D = List;
            return View();
        }

        public ActionResult Display()
        {
            if(Request.Form["txtStart"]!=null&& Request.Form["txtEnd"] != null)
            {
                ViewBag.D = Radiobtn.getDeptnos();
                //ViewBag.D = List;
                DateTime dt1=DateTime.Parse( Request.Form["txtStart"]);
              DateTime dt2 = DateTime.Parse(Request.Form["txtEnd"]);
              ViewBag.E=Radiobtn.getDate(dt1,dt2);
              
            }
            if (Request.Form["ddlDeptno"] != null)
            {
                int dno= int.Parse(Request.Form["ddlDeptno"]);
                ViewBag.Dno = dno;
                ViewBag.D = Radiobtn.getDeptnos();
                //ViewBag.D = List;
                ViewBag.E=Radiobtn.getEmp(dno);
                
            }

            return View("Index");
        }
    }
}