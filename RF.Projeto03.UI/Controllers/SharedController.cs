using RF.Projeto03.UI.Data;
using RF.Projeto03.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace RF.Projeto03.UI.Controllers
{
    public class SharedController:Controller
    {
        private readonly Projeto03DataContext _ctx = new Projeto03DataContext();

        public ViewResult _Layout()
        {
            return View();
        }

        public ActionResult Search(string nomeColab)
        {
            List<Colaboradores> res = (
                 from t in _ctx.Colaboradores
                 where t.nomeColab.Contains(nomeColab)
                 select t ).ToList();

            return PartialView(res);
        }

        [HttpGet]
        public ActionResult Show(int id)
        {
            var colaborador = _ctx.Colaboradores.Find(id);
            return View(colaborador);
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }

    }
}