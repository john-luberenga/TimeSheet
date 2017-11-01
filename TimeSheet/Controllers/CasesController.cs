using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TimeSheet.Models;

namespace TimeSheet.Controllers
{
    public class CasesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Cases
        public ActionResult Index()
        {
            return View(db.Cases.ToList());
        }

        // GET: Cases/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cases cases = db.Cases.Find(id);
            if (cases == null)
            {
                return HttpNotFound();
            }
            return View(cases);
        }

        // GET: Cases/Create
        public ActionResult Create()
        {
            Cases cs = new Cases();
            return View(cs);
        }

        public void FileDownload(int id)
        {
            var db = new ApplicationDbContext();
            if (id != 0)
            {
                var file = db.Cases.Where(x => x.id == id).Select(x => x);
                var data = file.FirstOrDefault();
                try
                {
                    Response.ContentType = "application/octet-stream";
                    Response.AddHeader("Content-Disposition", "attachment; filename=" + data.Title + ".docx");
                    Response.OutputStream.Write(data.File, 0, data.File.Length);
                    Response.Flush();
                }
                catch (Exception e)
                {
                    return;
                }

            }
        }

        // POST: Cases/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Creates([Bind(Include = "id,Title,Description,File,StartDate,EndDate")] Cases cases)
        {
            if (ModelState.IsValid)
            {
                db.Cases.Add(cases);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cases);
        }

        [HttpPost]
        public ActionResult Create(Cases model, HttpPostedFileBase File1)
        {
            var db = new ApplicationDbContext();
            if (File1 != null)
            {
                model.File = new byte[File1.ContentLength];
                File1.InputStream.Read(model.File, 0, File1.ContentLength);
            }
            db.Cases.Add(model);
            db.SaveChanges();

            return View(model);

        }

        // GET: Cases/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cases cases = db.Cases.Find(id);
            if (cases == null)
            {
                return HttpNotFound();
            }
            return View(cases);
        }

        // POST: Cases/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,Title,Description,File,StartDate,EndDate")] Cases cases)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cases).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cases);
        }

        // GET: Cases/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cases cases = db.Cases.Find(id);
            if (cases == null)
            {
                return HttpNotFound();
            }
            return View(cases);
        }

        // POST: Cases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cases cases = db.Cases.Find(id);
            db.Cases.Remove(cases);
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
