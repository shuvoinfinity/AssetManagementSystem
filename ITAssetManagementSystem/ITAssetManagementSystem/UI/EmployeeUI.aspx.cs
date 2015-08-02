using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITAssetManagementSystem.BLL;
using ITAssetManagementSystem.Model;

namespace ITAssetManagementSystem.UI
{
    public partial class EmployeeUI : System.Web.UI.Page
    {
        private EmployeeManager _aManager;
        EmployeeDataAccess aDataAccess;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllEmployees();    
            }
            
        }

        private void GetAllEmployees()
        {
            try
            {
                if (EmployeeDataAccess.GetAllUsers() == null)
                {
                    lblEmployee.Text = "Some error occored";
                }
                EmployeeGrid.DataSource = EmployeeDataAccess.GetAllUsers();
                EmployeeGrid.DataBind();
            }
            catch (Exception ex)
            {

                lblEmployee.Text = ex.Message;
            }
            
        }

        protected void GridUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string employeeId = e.Keys[0].ToString();
            EmployeeDataAccess.DeleteAnEmployee(employeeId);
            GetAllEmployees();
            //throw new NotImplementedException();
        }

        protected void btnEmplySave_Click(object sender, EventArgs e)
        {
            SaveAnEmployee();
            GetAllEmployees();
        }

        private void SaveAnEmployee()
        {
            _aManager = new EmployeeManager();   
            Employee newEmployee = new Employee();
            newEmployee.FirstName = txtEmpFirstName.Text;
            newEmployee.LastName = txtEmpLastName.Text;
            newEmployee.UserEmail = txtEmpEmail.Text;
            newEmployee.MobileNumber = txtEmpMobileNo.Text;
            newEmployee.Designation = txtEmpDesignation.Text;
            newEmployee.DepartmentCode = DropDownList1.SelectedValue;
            newEmployee.ExtentionNumber = txtEmpExtenNo.Text;
            //_aManager.SaveEmployee(newEmployee);
            lblEmployee.Text = _aManager.SaveEmployee(newEmployee);    
            EmptyAllTextBox();
        }

        private void EmptyAllTextBox()
        {
            txtEmpFirstName.Text = String.Empty;
            txtEmpLastName.Text = String.Empty;
            txtEmpEmail.Text = String.Empty;
            txtEmpDesignation.Text = String.Empty;
            txtEmpMobileNo.Text = String.Empty;
            txtEmpExtenNo.Text = String.Empty;
        }

        protected void EmployeeGrid_SelectedIndexChanged(object sender, EventArgs e)
        {
            _aManager = new EmployeeManager();

            int empId = Int32.Parse(EmployeeGrid.SelectedValue.ToString());//.SelectedRow.Cells[0].Text;
            //string eId = EmployeeGrid.Rows[EmployeeGrid.SelectedIndex].Cells[0].Text;
            //int empId = Int32.Parse(eId);
            Employee emp= _aManager.FindAnEmployee(empId);
            PopulateAnEmployee(emp);
            //EmployeeDataAccess.UpdateEmployee(employeeId);
            //GetAllEmployees();
        }

        private void PopulateAnEmployee(Employee anEmployee)
        {
            txtEmpFirstName.Text = anEmployee.FirstName;
            txtEmpLastName.Text = anEmployee.LastName;
            txtEmpEmail.Text = anEmployee.UserEmail;
            txtEmpMobileNo.Text = anEmployee.MobileNumber;
            txtEmpDesignation.Text = anEmployee.Designation;
            DropDownList1.Text = anEmployee.DepartmentCode;
            txtEmpExtenNo.Text = anEmployee.ExtentionNumber;
        }
    }
}