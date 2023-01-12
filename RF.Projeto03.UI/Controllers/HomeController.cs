using RF.Projeto03.UI.Data;
using RF.Projeto03.UI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;

namespace RF.Projeto03.UI.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly Projeto03DataContext _ctx = new Projeto03DataContext();
        public ViewResult Index()
        {

            var colaboradores = _ctx.Colaboradores.ToList();

            var dataInicial = DateTime.Now.AddDays(-30);
            var dataAtual = DateTime.Now;

            var count = _ctx.Colaboradores.Count();
            var query = from m in _ctx.Colaboradores
                        where m.datacadColab >= dataInicial && m.datacadColab <= dataAtual
                        select m;

            var countCad = query.Count();

            var revisao = from m in _ctx.Colaboradores
                        where m.Inativo == "Inativo"
                        select m;
            var revisaoCount = revisao.Count();

            ViewBag.Count = count.ToString();
            ViewBag.CountCad = countCad.ToString();
            ViewBag.RevisaoCount = revisaoCount.ToString();



            return View(colaboradores);
        }

        protected override void Dispose(bool disposing)
        {
            _ctx.Dispose();
        }
    }
}