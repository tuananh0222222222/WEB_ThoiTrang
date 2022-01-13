using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WEB_ThoiTrang.Areas.Admin.code;
using WEB_ThoiTrang.Areas.Admin.Data;

namespace WEB_ThoiTrang.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
           // var result = new AccoutModel().Login(model.UserName, model.PassWord);
            if(Membership.ValidateUser(model.UserName,model.PassWord) && ModelState.IsValid)
            {
                // SessionHelper.SetSession(new UserSession() { UserName = model.UserName });
                FormsAuthentication.SetAuthCookie(model.UserName, model.RememberMe);
                return RedirectToAction("Index", "Home");

            }
            else
            {
                ModelState.AddModelError("", "Tài khoản mật khẩu không chính xác!");
            }
            return View(model);


        }
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("index", "Login");
        }
    }
}