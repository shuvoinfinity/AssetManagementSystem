using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ITAssetManagementSystem.Model
{
    public class UserDataAccess
    {
        public static List<User> GetAllUsers()
        {
            try
            {
                using (var db = new FixAssetDB())
                {
                    return db.Users.ToList();
                }
            }
            catch (Exception aException)
            {

                throw new Exception(aException.Message);
            }
        }

        public static void DeleteUser(string userId)
        {
            throw new NotImplementedException();
        }
    }
}