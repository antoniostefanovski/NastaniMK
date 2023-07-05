﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using NastaniMK_2023.Models;

namespace NastaniMK_2023.Controllers
{
    public class EventsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Events
        [Authorize(Roles = "Administrator,Organizer,Moderator")]
        public ActionResult Index()
        {
            var events = db.Events.Include(o => o.Organizer);
            return View(events.ToList());
        }

        public ActionResult IndexUser()
        {
            var events = db.Events.Include(o => o.Organizer);
            return View(events.ToList());
        }

        [Authorize(Roles = "Administrator,Organizer,Moderator")]
        // GET: Events/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        public ActionResult DetailsUser(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            Organizer organizer = db.Organizers.Find(id);
            if (organizer == null)
            {
                return HttpNotFound();
            }

            var model = new OrganizerViewModel
            {
                Event = @event,
                Organizer = organizer
            };
            return View(model);
        }

        [Authorize(Roles = "Administrator,Organizer")]
        // GET: Events/Create
        public ActionResult Create()
        {
            ViewBag.OrganizerId = new SelectList(db.Organizers, "Id", "Name");
            return View();
        }

        // POST: Events/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Date,Time,Location,City,Tickets,ImageURL,OrganizerId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Events.Add(@event);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.OrganizerId = new SelectList(db.Organizers, "Id", "Name", @event.OrganizerId);
            return View(@event);
        }

        // GET: Events/Edit/5
        [Authorize(Roles = "Administrator,Organizer,Moderator")]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            ViewBag.OrganizerId = new SelectList(db.Organizers, "Id", "Name", @event.OrganizerId);
            return View(@event);
        }

        // POST: Events/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Date,Time,Location,City,Tickets,ImageURL,OrganizerId")] Event @event)
        {
            if (ModelState.IsValid)
            {
                db.Entry(@event).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.OrganizerId = new SelectList(db.Organizers, "Id", "Name", @event.OrganizerId);
            return View(@event);
        }

        // GET: Events/Delete/5
        [Authorize(Roles = "Administrator,Organizer")]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Event @event = db.Events.Find(id);
            if (@event == null)
            {
                return HttpNotFound();
            }
            return View(@event);
        }

        // POST: Events/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Event @event = db.Events.Find(id);
            db.Events.Remove(@event);
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

        public ActionResult BuyTickets(int id)
        {
            Event model = db.Events.Find(id);
            BuyTicketModel model2 = new BuyTicketModel();

            model2.Price = 60;

            CombinedModel combinedModel = new CombinedModel
            {
                EventName = model.Name,
                EventId = model.Id,
                BuyTicketModel = model2
            };


            return View(combinedModel);
        }

        [HttpPost]
        public ActionResult OnBuyTickets(CombinedModel model)
        {
            if(!ModelState.IsValid)
            {
                return View("BuyTickets", model);
            }
            int price = model.BuyTicketModel.Price;
            return View("BoughtTickets", model);
        }

        public ActionResult BoughtTickets(CombinedModel model)
        {
            return View(model);
        }

        public ActionResult FinalizeBuyProcess()
        {
            return View();
        }
    }
}
