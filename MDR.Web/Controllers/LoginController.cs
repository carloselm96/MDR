using MDR.Web.Models.DataAccess;
using MDR.Web.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MDR.Web.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        

        [HttpPost]
        [AllowAnonymous]
        public ActionResult Login(LoginUser u)
        {

            var user = LoginRepository.Authenticate(u);
            if (user != null)
            {
                if (user.PASSWORD == u.Password)
                {
                    FormsAuthentication.SetAuthCookie(user.USER, false);

                    Session["username"] = user.USER;
                    Session["id"] = user.USER_ID;
                    Session["tipo"] = user.USER_TYPE_FK;
                    Session["name"] = user.NAME;
                    return RedirectToAction("Index", "Home");
                }
            }
            ModelState.AddModelError("Password", "Contraseña o Usuario Incorrectos");
            return View();
        }

        [Authorize]
        public ActionResult Logout()
        {
            Session.Contents.RemoveAll();
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }
    }
}