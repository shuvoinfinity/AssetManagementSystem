using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
                using (var db = new FixAssetDB())
                {
                    var users = db.Users.ToList();
                    GridUsers.DataSource = users;
                    GridUsers.DataBind();
                }
            }
            catch (Exception)
            {
                lblUser.Text = "User Not Found";
            }
        }
    }
}