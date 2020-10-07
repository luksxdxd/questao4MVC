using MvcProva4.Context;
using MvcProva4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProva4.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly Contexto db = new Contexto();

        // GET: Professor
        public ActionResult Index()
        {
            return View(db.Professores.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Professor prof)
        {
            if (ModelState.IsValid)
            {
                db.Professores.Add(prof);
                db.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(prof);
        }
    }
}