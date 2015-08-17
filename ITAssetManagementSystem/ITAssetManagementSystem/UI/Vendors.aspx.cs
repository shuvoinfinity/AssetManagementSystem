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
    public partial class Vendors : System.Web.UI.Page
    {
        private VendorManager vendorManager;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllVendors();
            }
        }

        private void GetAllVendors()
        {
            vendorManager = new VendorManager();
            grdVendor.DataSource = vendorManager.GetAllVendors();
            grdVendor.DataBind();
        }

        protected void btnSaveVendor_onclick(object sender, EventArgs e)
        {
            vendorManager = new VendorManager();
            Vendor vendor = new Vendor();
            vendor.Name = txtVendortName.Text;
            vendor.Email = txtVendorEmail.Text;
            vendor.Address = txtVendorAddress.Text;
            vendor.Phone = txtVendorPhone.Text;
            lblVendorsInsert.Text = vendorManager.AddNewVendor(vendor);
            ClearTxtBox();
            GetAllVendors();
        }

        private void ClearTxtBox()
        {
            txtVendortName.Text = String.Empty;
            txtVendorEmail.Text = string.Empty;
            txtVendorAddress.Text = string.Empty;
            txtVendorPhone.Text = string.Empty;
        }

        protected void grdVendor_SelectedIndexChanged(object sender, EventArgs e)
        {
            vendorManager = new VendorManager();

            int vendorID = Int32.Parse(grdVendor.SelectedValue.ToString());
            Vendor vendor = vendorManager.FindAVendor(vendorID);

            txtVendortName.Text = vendor.Name;
            txtVendorEmail.Text = vendor.Email;
            txtVendorAddress.Text = vendor.Address;
            txtVendorPhone.Text = vendor.Phone;

        }

        protected void grdVendor_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            vendorManager = new VendorManager();
            string rowKey = e.Keys[0].ToString();

            int vendorID = Int32.Parse(rowKey);
            lblVendorsInsert.Text = vendorManager.DeleteVendor(vendorID);
            GetAllVendors();
        }


        protected void btnUpdateVendor_onclick(object sender, EventArgs e)
        {
            vendorManager = new VendorManager();

            int vendorID = Int32.Parse(grdVendor.SelectedValue.ToString());
            Vendor vendor = vendorManager.FindAVendor(vendorID);

            vendor.Name = txtVendortName.Text;
            vendor.Email = txtVendorEmail.Text;
            vendor.Address = txtVendorAddress.Text;
            vendor.Phone = txtVendorPhone.Text;

            lblVendorsInsert.Text = vendorManager.UpdateVendor(vendor);
            ClearTxtBox();
        }
    }
}