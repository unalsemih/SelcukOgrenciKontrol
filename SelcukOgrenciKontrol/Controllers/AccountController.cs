using SelcukOgrenciKontrol.Models.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SelcukOgrenciKontrol.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Login()
        {
            User user = new User();            
            return View(user);
        }
    }
}