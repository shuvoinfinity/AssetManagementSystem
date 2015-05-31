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
            catch (Exception aException)
            {

                throw new Exception(aException.Message);
            }
        }

        public static void SaveEmployeeInfo(Employee newEmployee)
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
    }
}