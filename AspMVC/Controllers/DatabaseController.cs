using AspMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspMVC.Controllers
{
    public class DatabaseController : Controller
    {
        // GET: Database
       static List<DEPTDATA> list = null;
        static List<EMPDATA> list1 = null;
        public ActionResult Index()
        {
            EMPDATA E = new EMPDATA();
            return View(E);
        }
        [HttpPost]
        public ActionResult Index(EMPDATA E)
        {
            ViewBag.msg=DBOperations.InsertEmp(E);
            return View();
        }

        public ActionResult getDeptData()
        {          
            return View();
        }

        public ActionResult GetData()
        {
            int deptno = int.Parse(Request.Form["txtDeptno"]);
            List<EMPDATA> L = DBOperations.GetDept(deptno);
            return View("getDeptData", L);

            //int deptno = int.Parse(Request.Form["txtxDeptno"]);
            //ViewBag.L = DBOperations.GetDept(deptno);
            //return View("getDeptData");
        }

        public ActionResult Action()
        {
           
            return View();
        }
        
        public ActionResult Action1()
        {
            int empno = int.Parse(Request.QueryString["e"]);
            EMPDATA Emp = DBOperations.GetEmp(empno);
            return View("Action",Emp );
        }

        public ActionResult Update(EMPDATA E)
        {
            ViewBag.msg = DBOperations.UpdateEmp(E);
            return View("Action");
        }

        public ActionResult getDepts()
        {
            list = DBOperations.getDepts();
            ViewBag.L = list;
            return View();
        }

        public ActionResult SendDept()
        {
            int deptno = int.Parse(Request.QueryString["d"]);
            ViewBag.dno = deptno;
            ViewBag.L = list;
            List<EMPDATA> L = DBOperations.GetDept(deptno);
            return View("getDepts",L);
        }

        public ActionResult getEmpno()
        {
            list1= DBOperations.getEmpno();
            ViewBag.L = list1;
            return View();
        }

        public ActionResult Display()
        {
            int eno = int.Parse(Request.Form["ddlEmpno"]);
            ViewBag.L = list1;
            ViewBag.eno = eno;
            ViewBag.msg= DBOperations.DelEmpno(eno);
            return View("getEmpno");
        }

        public ActionResult Dates()
        {
            return View();
        }

        public ActionResult DisplayDate()
        {
            DateTime dt1 = DateTime.Parse(Request.Form["txtStart"]);
            DateTime dt2 = DateTime.Parse(Request.Form["txtEnd"]);
            ViewBag.Emp=DBOperations.ExtractDate(dt1,dt2);
            return View("Dates");
        }

    }
}