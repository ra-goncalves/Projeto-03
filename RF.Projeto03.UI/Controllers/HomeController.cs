using RF.Projeto03.UI.Data;
using RF.Projeto03.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RF.Projeto03.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly Projeto03DataContext _ctx = new Projeto03DataContext();
        public ViewResult Index()
        {

            var colaboradores = _ctx.Colaboradores.ToList();

            return View(colaboradores);
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}