using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.DataAccessLayer;
using System.Data.Entity;

//业务层
namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {
            using (SalesERPDAL dal = new SalesERPDAL())
            {
              
                var list = dal.Employees.ToList();
                return list;
            }   

        }
        //添加
        public void Add(Employee emp)
        {
            //实例上下文
            using (SalesERPDAL dal = new SalesERPDAL())
            {

                dal.Employees.Add(emp);
                //返回被影响的行数。
                dal.SaveChanges();
            }
        }
        //删除
        public void Delete(int id)
        {
            using (SalesERPDAL dlt = new SalesERPDAL())
            {
                Employee emp = dlt.Employees.Find(id);
                dlt.Entry(emp).State = EntityState.Deleted;
                dlt.SaveChanges();
                
            }

        }
        //更新
       public void UpdateSaveEmployee(Employee emp)
        {
            using (SalesERPDAL dal =new SalesERPDAL())
            {
                dal.Entry(emp).State = EntityState.Modified;
                dal.SaveChanges();
            }
        }
        public Employee Query(int id)
        {
            using (var db=new SalesERPDAL())
            {
                Employee emp = db.Employees.Find(id);
                return emp;
            }
        }
        //查询
       public List<Employee> Search(string searchString)
        {
            using (var dal = new SalesERPDAL())
            {
                return dal.Employees.Where(e => e.Name.Contains(searchString)).ToList();
                 
            }
            
        }

    }
}