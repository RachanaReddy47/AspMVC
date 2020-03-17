using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AspMVC.Models
{
    public class Radiobtn
    {
        static DemoEntities D = new DemoEntities();

        public static List<DEPTDATA> getDeptnos()
        {
            var Dep = from L in D.DEPTDATAs
                      select L;
            return Dep.ToList();
        }

        public static List<EMPDATA> getDate(DateTime dt1,DateTime dt2)
        {
            var Date = from L in D.EMPDATAs
                       where L.HIREDATE >= dt1 && L.HIREDATE <= dt2
                       select L;
            return Date.ToList();
        }

        public static List<EMPDATA> getEmp(int dno)
        {
            var Emp = from L in D.EMPDATAs
                      where L.DEPTNO == dno
                      select L;
            return Emp.ToList();
        }
    }
}