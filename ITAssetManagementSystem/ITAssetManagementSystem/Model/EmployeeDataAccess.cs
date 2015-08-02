using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Web;
using ITAssetManagementSystem.Model;

namespace ITAssetManagementSystem.Model
{
    public class EmployeeDataAccess
    {
        public static List<Employee> GetAllUsers()
        {
            try
            {
                using (var db = new FixAssetDBEntities())
                {
                    return db.Employees.ToList();
                }
            }
            catch (Exception e)
            {
                return new List<Employee>();
            }
                
            
        }

        public void SaveEmployeeInfo(Employee newEmployee)
        {
           using (var db = new FixAssetDBEntities())
            {
                db.Employees.Add(newEmployee);
                db.SaveChanges();
            }
            
        }

        public static void DeleteAnEmployee(string employeeId)
        {
            if (employeeId!=null)
            {
                using (var db = new FixAssetDBEntities())
                {
                    int empId = Int16.Parse(employeeId);
                    var anemployee = (from emp in db.Employees
                        where emp.EmployeeId == empId
                        select emp).FirstOrDefault();
                    db.Employees.Remove(anemployee);
                    db.SaveChanges();
                }
            }
        }

        public Employee FindAnEmployee(int employeeId)
        {
            //List<EmployeeUI> employees = new List<EmployeeUI>();
            using (var db = new FixAssetDBEntities())
                {
                    //int empId = Int16.Parse(employeeId);
                  var  anEmployee = (from emp in db.Employees
                                      where emp.EmployeeId == employeeId
                                      select emp).FirstOrDefault();
                    return anEmployee;
                }
            
        }

        public void UpdateEmployee(Employee anEmployee)
        {
          
            using (var db = new FixAssetDBEntities())
                {
                    //int empId = Int16.Parse(employeeId);
                    
                    db.SaveChanges();
                }
            
        }

        public bool HasThisEmployee(int empId)
        {
                using (var db = new FixAssetDBEntities())
                {
                    bool hasEmp = db.Employees.Any(x => x.EmployeeId == empId);
                    return hasEmp;
                }
           
        }
    }
}