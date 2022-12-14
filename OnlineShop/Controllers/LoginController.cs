using Model.Dao;
using OnlineShop.Areas.Admin.Models;
using OnlineShop.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session[CommonConstant.USER_SESSION] = null;
            return Redirect("/");
        }
        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDao();
                if (dao.CheckUser(model.Username, model.Password) == 1)
                {
                    ModelState.AddModelError("", "Username và password nhập vào phải <= 25 kí tự");
                }
                else if (dao.CheckUser(model.Username, model.Password) == 2)
                {
                    ModelState.AddModelError("", "Username và password nhập vào phải >= 8");
                }
                else
                {

                    var result = dao.Login(model.Username, Encrytor.MD5Hash(model.Password), false);
                    if (result == 1)
                    {
                        var user = dao.GetUserName(model.Username);
                        var userSesstion = new UserLogin();
                        userSesstion.Username = user.Username;
                        userSesstion.UserID = user.ID;
                        Session.Add(CommonConstant.USER_SESSION, userSesstion);
                        return Redirect("/Home/Index");
                    }
                    else
                    {
                        if (result == 0)
                        {
                            ModelState.AddModelError("", "Tài khoản không tồn tại");
                        }
                        else
                            if (result == -1)
                        {
                            ModelState.AddModelError("", "Đăng nhập không đúng");
                        }
                        else
                            if (result == -2)
                        {
                            ModelState.AddModelError("", "Tài khoản đang bị khóa");
                        }
                        else
                            if (result == -3)
                        {
                            ModelState.AddModelError("", "Bạn không có quyền đăng nhập vào");
                        }
                    }
                }


            }
            return View("Index");
        }
    }
}