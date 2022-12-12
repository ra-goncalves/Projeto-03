using RF.Projeto03.UI.Data;
using RF.Projeto03.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RF.Projeto03.UI.Controllers
{
    public class CadastrosController : Controller
    {
        private readonly Projeto03DataContext _ctx = new Projeto03DataContext();
        public ViewResult Index()
        {
            var colaboradores = _ctx.Colaboradores.ToList();

            return View(colaboradores);

        }

        [HttpGet]
        public ViewResult Cadastro()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var colaborador = _ctx.Colaboradores.Find(id);
            return View(colaborador);
        }

        [HttpPost]
        public ActionResult Edit(Colaboradores colaborador)
        {
            _ctx.Entry(colaborador).State = System.Data.Entity.EntityState.Modified;
            _ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Cadastro(Colaboradores colaborador)
        {
            _ctx.Colaboradores.Add(colaborador);
            _ctx.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult DelColab(int id)
        {
            var colaborador = _ctx.Colaboradores.Find(id);
            if (colaborador == null)
            {
                return HttpNotFound();
            }
            _ctx.Colaboradores.Remove(colaborador);
            _ctx.SaveChanges();

            return null;
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}