using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using SadCabelereiro.Models;

namespace SadCabelereiro.Controllers
{
    public class ServicoController : Controller
    {
        //
        // GET: /Servico/

        private sad_cabeleireiroEntities  bd = new sad_cabeleireiroEntities();

        public ActionResult Index()
        {
            var servico = bd.Servico.ToList();

            return View(servico);
        }

        //
        // GET: /Servico/Details/5

        public ActionResult Details(int id)
        {
            Servico serv = bd.Servico.Find(id);
            if (serv == null)
            {
                RedirectToAction("Index");
            }
            return View(serv);
        }

        //
        // GET: /Servico/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Servico/Create

        [HttpPost]
        public ActionResult Create(Servico servico)
        {
            if (ModelState.IsValid)
            {
                bd.Servico.Add(servico);
                bd.SaveChanges();

                return RedirectToAction("Index");
            }

            return View(servico);
        }

        //
        // GET: /Servico/Edit/5

        public ActionResult Edit(int id)
        {
            Servico serv = bd.Servico.Find(id);
            if (serv == null)
            {
                return RedirectToAction("Index");                
            }
            return View(serv);
        }

        //
        // POST: /Servico/Edit/5

        [HttpPost]
        public ActionResult Edit(Servico serv)
        {
            if (ModelState.IsValid)
            {
                bd.Entry(serv).State = EntityState.Modified;
                bd.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serv);
        }

        //
        // GET: /Servico/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Servico/Delete/5

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
