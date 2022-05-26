using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using E_TradingApiSprint.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_TradingApiSprint.Controllers

{
    public class HomeController : ControllerBase
    {
        private object ViewBag;

        public ActionResult Index()
        {
            LoginModel obj = new LoginModel();
            return View(obj);
        }

        private ActionResult View(LoginModel obj)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Index(LoginModel objuserlogin)
        {
            var display = Userloginvalues().Where(m => m.UserName == objuserlogin.UserName && m.UserPassword == objuserlogin.UserPassword).FirstOrDefault();
            if (display != null)
            {
                ViewBag = "CORRECT UserNAme and Password";
            }
            else
            {
                ViewBag = "INCORRECT UserName or Password";
            }
            return View(objuserlogin);
        }
        public List<LoginModel> Userloginvalues()
        {
            List<LoginModel> objModel = new List<LoginModel>();
            objModel.Add(new LoginModel { UserName = "user1", UserPassword = "password1" });
            objModel.Add(new LoginModel { UserName = "user2", UserPassword = "password2" });
            objModel.Add(new LoginModel { UserName = "user3", UserPassword = "password3" });
            objModel.Add(new LoginModel { UserName = "user4", UserPassword = "password4" });
            objModel.Add(new LoginModel { UserName = "user5", UserPassword = "password5" });
            return objModel;
        }
    }
}
