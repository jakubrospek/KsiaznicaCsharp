﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KsiaznicaCsharp.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult LogIn()
        {
            return View();
        }

        public ActionResult SignIn()
        {
            return View();
            //return RedirectToRoute("temporary", "Home");
        }
    }
}