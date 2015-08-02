using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ITAssetManagementSystem.Model;

namespace ITAssetManagementSystem.BLL
{
    public class EmployeeManager
    {
        public EmployeeDataAccess anDataAccess = new EmployeeDataAccess();
        public string SaveEmployee(Employee newEmployee)
        {
            string msg = null;
            try
            {
                if (newEmployee.FirstName == string.Empty || newEmployee.LastName == string.Empty || newEmployee.UserEmail == string.Empty || newEmployee.MobileNumber == string.Empty || newEmployee.Designation == string.Empty || newEmployee.DepartmentCode == string.Empty)
                {
                    return msg = "Please Put all values";
                    
                    
                }
                else
                {
                    if (!HasThisEmployee(newEmployee.EmployeeId))
                    {
                        anDataAccess.SaveEmployeeInfo(newEmployee);
                        return msg = "Successful";
                    }
                    anDataAccess.UpdateEmployee(newEmployee);
                }
            }
            catch (Exception exp)
            {

                return exp.Message;
            }
            return msg = "Successfully Updated";
        }
        public Employee FindAnEmployee(int employeeId)
        {
            Employee anEmployee = null;
            //List<EmployeeUI> employees = new List<EmployeeUI>();
            return anDataAccess.FindAnEmployee(employeeId);
            
        }

        private bool HasThisEmployee(int empId)
        {
            return anDataAccess.HasThisEmployee(empId);
            
        }
    }
}