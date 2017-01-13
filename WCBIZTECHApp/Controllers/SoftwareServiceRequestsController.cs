using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WCBIZTECHApp.Models;

namespace WCBIZTECHApp.Controllers
{
    public class SoftwareServiceRequestsController : Controller
    {
        private wcbiztechappazdbEntities db = new wcbiztechappazdbEntities();

        // GET: SoftwareServiceRequests
        public ActionResult Index()
        {
            return View(db.SoftwareServiceRequests.ToList());
        }

        // GET: SoftwareServiceRequests/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoftwareServiceRequest softwareServiceRequest = db.SoftwareServiceRequests.Find(id);
            if (softwareServiceRequest == null)
            {
                return HttpNotFound();
            }
            return View(softwareServiceRequest);
        }

        // GET: SoftwareServiceRequests/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SoftwareServiceRequests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RequestId,LastName,FirstName,YourCompany,YourTitle,City,State,Country,Telephone,Email,ServiceRequested,Message")] SoftwareServiceRequest softwareServiceRequest)
        {
            if (ModelState.IsValid)
            {
                softwareServiceRequest.RequestId = Guid.NewGuid();
                db.SoftwareServiceRequests.Add(softwareServiceRequest);
                db.SaveChanges();
                return RedirectToAction("AfterSubmission", "Offerings"); 
            }

            return View(softwareServiceRequest);
        }

        // GET: SoftwareServiceRequests/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoftwareServiceRequest softwareServiceRequest = db.SoftwareServiceRequests.Find(id);
            if (softwareServiceRequest == null)
            {
                return HttpNotFound();
            }
            return View(softwareServiceRequest);
        }

        // POST: SoftwareServiceRequests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RequestId,LastName,FirstName,YourCompany,YourTitle,City,State,Country,Telephone,Email,ServiceRequested,Message")] SoftwareServiceRequest softwareServiceRequest)
        {
            if (ModelState.IsValid)
            {
                db.Entry(softwareServiceRequest).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(softwareServiceRequest);
        }

        // GET: SoftwareServiceRequests/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SoftwareServiceRequest softwareServiceRequest = db.SoftwareServiceRequests.Find(id);
            if (softwareServiceRequest == null)
            {
                return HttpNotFound();
            }
            return View(softwareServiceRequest);
        }

        // POST: SoftwareServiceRequests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            SoftwareServiceRequest softwareServiceRequest = db.SoftwareServiceRequests.Find(id);
            db.SoftwareServiceRequests.Remove(softwareServiceRequest);
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
