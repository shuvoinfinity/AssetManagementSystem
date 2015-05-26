using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ITAssetManagementSystem.BLL;
using ITAssetManagementSystem.Model;

namespace ITAssetManagementSystem.UI
{
  
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllUsers();
        }

        private void GetAllUsers()
        {
            try
            {
                GridUsers.DataSource=UserDataAccess.GetAllUsers();
                GridUsers.DataBind();

            }
            catch (Exception e)
            {
                lblUser.Text = e.Message;
            }
        
        }

        protected void GridUsers_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string userId = e.Keys[0].ToString();
            UserDataAccess.DeleteUser(userId);
        }

        
    }
}