using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Compumatrice_assignment1.Models;
using System.Dynamic;

namespace Compumatrice_assignment1.Controllers
{
    public class RegisterFormController : Controller
    {
        public Registration_formEntities db = new Registration_formEntities();

        //
        // GET: /RegisterForm/

        public ActionResult Index()
        {
            return View(db.tbl_Registrationform.ToList());
        }

        //
        // GET: /RegisterForm/Details/5

        public ActionResult Details(int id = 0)
        {
            tbl_Registrationform tbl_registrationform = db.tbl_Registrationform.Single(t => t.id == id);
            if (tbl_registrationform == null)
            {
                return HttpNotFound();
            }
            return View();
        }

        //
        // GET: /RegisterForm/Create

        public ActionResult Create()
        {
            //ViewData["register_table"] = db.tbl_Registrationform;
            return View();
        }

        //
        // POST: /RegisterForm/Create

        [HttpPost]
        public ActionResult Create(tbl_Registrationform tbl_registrationform)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Registrationform.AddObject(tbl_registrationform);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

           // ViewData["register_table"] = db.tbl_Registrationform;
            return View(tbl_registrationform);
        }

        //
        // GET: /RegisterForm/Edit/5

        public ActionResult Edit(int id = 0)
        {
            tbl_Registrationform tbl_registrationform = db.tbl_Registrationform.Single(t => t.id == id);
            if (tbl_registrationform == null)
            {
                return HttpNotFound();
            }
            return View(tbl_registrationform);
        }

        //
        // POST: /RegisterForm/Edit/5

        [HttpPost]
        public ActionResult Edit(tbl_Registrationform tbl_registrationform)
        {
            if (ModelState.IsValid)
            {
                db.tbl_Registrationform.Attach(tbl_registrationform);
                db.ObjectStateManager.ChangeObjectState(tbl_registrationform, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_registrationform);
        }

        //
        // GET: /RegisterForm/Delete/5

        public ActionResult Delete(int id = 0)
        {
            tbl_Registrationform tbl_registrationform = db.tbl_Registrationform.Single(t => t.id == id);
            if (tbl_registrationform == null)
            {
                return HttpNotFound();
            }
            return View(tbl_registrationform);
        }

        //
        // POST: /RegisterForm/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_Registrationform tbl_registrationform = db.tbl_Registrationform.Single(t => t.id == id);
            db.tbl_Registrationform.DeleteObject(tbl_registrationform);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}