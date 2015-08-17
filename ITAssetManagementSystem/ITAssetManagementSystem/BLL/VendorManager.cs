using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ITAssetManagementSystem.Model;

namespace ITAssetManagementSystem.BLL
{
    public class VendorManager
    {
        private VendorDataAccess vendorData = new VendorDataAccess();
        public List<Vendor> GetAllVendors()
        {
            return vendorData.AllVendors();

        }

        public string AddNewVendor(Vendor vendor)
        {
            return vendorData.AddVendor(vendor);
        }

        public Vendor FindAVendor(int vendorId)
        {
            return vendorData.FindVendor(vendorId);
        }


        public string UpdateVendor(Vendor vendor)
        {

            return vendorData.Update(vendor.VendorId, vendor.Name, vendor.Email, vendor.Address, vendor.Phone);
        }

        public string DeleteVendor(int vendorId)
        {
            return vendorData.DeleteVendor(vendorId);
        }
    }
}