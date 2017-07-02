using KsiaznicaCsharp.DataAccessLayer;
using KsiaznicaCsharp.Models;
using KsiaznicaCsharp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KsiaznicaCsharp.Controllers
{
    public class AccountController : Controller
    {

        private DataContext db = new DataContext();

        // GET: Account
        public ActionResult LogIn(string returnUrl)
        {
            //Book newBook = new Book { BookAuthor = "Sapkowski" };
            //db.Books.Add(newBook);
            //db.SaveChanges();

            //var booksList = db.Books.ToList();

            ViewBag.ReturnUrl = returnUrl;
            return View();
        }

        [HttpPost]
        public ActionResult LogIn(LoginViewModel model, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
                return RedirectToAction("Index", "Home");
        }

        public ActionResult SignIn()        // rejestracja
        {
            return View();
            //return RedirectToRoute("temporary", "Home");
        }

        [HttpPost]
        public ActionResult SignIn(RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            else
                return RedirectToAction("Index", "Home");
        }
    }
}