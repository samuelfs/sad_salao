using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SadCabelereiro.Controllers
{
    public class AtendimentoController : Controller
    {
        //
        // GET: /Atendimento/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Atendimento/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Atendimento/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Atendimento/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Atendimento/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Atendimento/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Atendimento/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Atendimento/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
