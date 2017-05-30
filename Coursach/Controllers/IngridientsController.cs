﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coursach;

namespace Coursach.Controllers
{
    public class IngridientsController : Controller
    {
        private MenuUnitEntities db = new MenuUnitEntities();

        // GET: Ingridients
        public ActionResult Index()
        {
            return View(db.Ingredient.ToList());
        }

        // GET: Ingridients/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ingridients/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Cost")] Ingredient ingridient)
        {
            if (ModelState.IsValid)
            {
                db.Ingredient.Add(ingridient);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ingridient);
        }

        // GET: Ingridients/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient ingridient = db.Ingredient.Find(id);
            if (ingridient == null)
            {
                return HttpNotFound();
            }
            return View(ingridient);
        }

        // POST: Ingridients/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Cost")] Ingredient ingridient)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ingridient).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ingridient);
        }

        // GET: Ingridients/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ingredient ingridient = db.Ingredient.Find(id);
            if (ingridient == null)
            {
                return HttpNotFound();
            }
            return View(ingridient);
        }

        // POST: Ingridients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ingredient ingridient = db.Ingredient.Find(id);
            db.Ingredient.Remove(ingridient);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
