using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace MDR.Web.Models.DataAccess
{
    public class LoginRepository
    {
        public static users Authenticate(LoginUser u)
        {
            micronaEntities db = new micronaEntities();
            var user = db.users.Where(x => u.UserName.ToUpper() == x.USER.ToUpper() && x.STATUS.Equals("A")).FirstOrDefault();
            return user;
        }
    }
}