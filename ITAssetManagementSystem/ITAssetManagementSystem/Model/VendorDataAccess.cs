using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITAssetManagementSystem.Model
{
    public class VendorDataAccess
    {
        public List<Vendor> AllVendors()
        {
            using (var db = new FixAssetDBEntities())
            {
                return db.Vendors.ToList();
            }
        }

        public string AddVendor(Vendor vendor)
        {
            using (var db = new FixAssetDBEntities())
            {
                try
                {
                    db.Vendors.Add(vendor);
                    db.SaveChanges();
                    return "New Vendor Saved Succesfully";
                }
                catch (Exception exception)
                {

                    return exception.Message;
                }
            }
        }

        public Vendor FindVendor(int vendorId)
        {
            using (var DB = new FixAssetDBEntities())
            {
                Vendor aVendor = DB.Vendors.Find(vendorId);
                return aVendor;
            }
        }

        public string Update(int vendorId, string name, string email, string address, string phone)
        {
            using (var DB = new FixAssetDBEntities())
            {
                var vendr = DB.Vendors.SingleOrDefault(x => x.VendorId == vendorId);
                vendr.Name = name;
                vendr.Email = email;
                vendr.Address = address;
                vendr.Phone = phone;
                DB.SaveChanges();
                return "Success";
            }
        }

        public string DeleteVendor(int vendorId)
        {
            try
            {
                using (var DB = new FixAssetDBEntities())
                {
                    var vdr = DB.Vendors.SingleOrDefault(x => x.VendorId == vendorId);
                    DB.Vendors.Remove(vdr);
                    DB.SaveChanges();
                    return "Vendor Deleted!!";
                }
            }
            catch (Exception exp)
            {
                return exp.Message;
            }
            
        }
    }
}