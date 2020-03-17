using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace AspMVC.Models
{
    public  class DBOperations
    {
        static DemoEntities D = new DemoEntities();


        public static string InsertEmp(EMPDATA A)
        {
            try
            {
                D.EMPDATAs.Add(A);
                D.SaveChanges();
            }
            catch(DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
                if (ex.Message.Contains("EMP_PK"))
                    return "Employee no already Exists";
                else if (ex.Message.Contains("FK__EMPDATA_DEPTNO"))
                    return "No such Deptno exists";
                else
                    return "Error Ocurred";
            }
            return "1 row inserted";
        }

        public static List<EMPDATA> GetDept(int Deptno)
        {
            var LE = from L in D.EMPDATAs
                     where L.DEPTNO == Deptno
                     select L;
            return LE.ToList();

        }

        public static List<EMPDATA> ExtractEmp(EMPDATA E)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == E.EMPNO
                     select L;
            return LE.ToList();
        }

        public static List<DEPTDATA> getDepts()
        {
            var dept = from D1 in D.DEPTDATAs
                       select D1;
            return dept.ToList();
        }

        public static List<EMPDATA> getEmpno()
        {
            var Empno = from E in D.EMPDATAs
                        select E;
            return Empno.ToList();
        }

        public static string DelEmpno(int eno)
        {
            var Empno = from E in D.EMPDATAs
                        where E.EMPNO == eno
                        select E;
            EMPDATA Eno =Empno.First();
            D.EMPDATAs.Remove(Eno);
            D.SaveChanges();

            return "1 row deleted";
          

        }

        public static EMPDATA GetEmp(int eno)
        {
            var LE = from L in D.EMPDATAs
                     where L.EMPNO == eno
                     select L;
            EMPDATA Empno= LE.First();
            return Empno;
        }

        public static string UpdateEmp(EMPDATA A)
        {
            try
            {
                var LE = from L in D.EMPDATAs
                         where L.EMPNO == A.EMPNO
                         select L;
                EMPDATA a = LE.First();
                a.ENAME = A.ENAME;
                a.JOB = A.JOB;
                a.MGR = A.MGR;
                a.SAL = A.SAL;
                D.SaveChanges();

            }
            catch(DbUpdateException E)
            {
                SqlException ex = E.GetBaseException() as SqlException;
            }
            return "1 row updated";
        }

        public static List<EMPDATA> ExtractDate(DateTime dt1, DateTime dt2)
        {
            var Emp = from L in D.EMPDATAs
                      where L.HIREDATE >= dt1 && L.HIREDATE <= dt2
                      select L;
            return Emp.ToList();
        }

    }
}