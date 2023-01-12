using RF.Projeto03.UI.Data;
using RF.Projeto03.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace RF.Projeto03.UI.Controllers
{
    public class LoginController:Controller
    {
        private readonly Projeto03DataContext _ctx = new Projeto03DataContext();

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginVM model)
        {
            var usuario = _ctx.Usuarios.FirstOrDefault(u => u.email.ToLower() == model.email.ToLower());

            if (usuario == null)
                ModelState.AddModelError("email", "Email não localizado");
       
            else
            {
                if (usuario.senha != model.senha)
                    ModelState.AddModelError("senha", "Senha invalida");
            }

            if (ModelState.IsValid)
            {
                FormsAuthentication.SetAuthCookie(model.email, true);
                return RedirectToAction("Index", "Home");
            }

            return View(model);
        }

        [HttpGet]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}