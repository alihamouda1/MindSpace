
using DATA;
using Domain;
using Epione.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Epione.Controllers
{

    [Authorize(Roles ="SuperAdmin")]
    public class AdminController : Controller
    {

        MyContext context = new MyContext();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateUser()
        {
          
            return View();
        }

        [HttpPost]
        public ActionResult CreateUser(FormCollection form)
        {
            var UserManager = new UserManager<User, int>(new UserStore<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>(context));
            string UserName = form["txtEmail"];
            string email = form["txtEmail"];
            string pwd = form["txtPassword"];
            var user = new User();
            user.UserName = UserName;

            user.Email = email;
            user.Password = pwd; 


            var chkUser = UserManager.Create(user);
            if (chkUser.Succeeded)
            {
                var result1 = UserManager.AddToRole(user.Id, "SuperAdmin")
                ;
            }
            return View();


            ///////////////////////////////////////////////////










        }
        public ActionResult AssignRole()
        {

            return View();
        }





    }


}