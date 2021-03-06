﻿using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MelodyShop.DataAccessLayer;
using MelodyShop.Models;

namespace MelodyShop.Controllers
{
  public class DataToOrdersController : Controller
  {
    private ApplicationDbContext db = new ApplicationDbContext();

    // GET: DataToOrders
    public ActionResult Index()
    {
      var dataToOrders = db.DataToOrders.Include(d => d.Cart);
      return View(dataToOrders.ToList());
    }

    // GET: DataToOrders/Details/5
    public ActionResult Details(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      DataToOrder dataToOrder = db.DataToOrders.Find(id);
      if (dataToOrder == null)
      {
        return HttpNotFound();
      }
      return View(dataToOrder);
    }

    // GET: DataToOrders/Create
    public ActionResult Create()
    {
      ViewBag.cartId = new SelectList(db.Carts, "id", "id");
      return View();
    }

    // POST: DataToOrders/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "id,name,surname,email,phoneNumber,street,hoseNumber,postalCode,city,country,messageToOrder,cartId")] DataToOrder dataToOrder)
    {
      //if (ModelState.IsValid)
      //{
      //  db.DataToOrders.Add(dataToOrder);
      //  db.SaveChanges();
      //  return RedirectToAction("Index");
      //}

      //ViewBag.cartId = new SelectList(db.Carts, "id", "id", dataToOrder.cartId);
      TempData["SM"] = "Dziękujemy, Twoje zamówienie zostało dodane. Niebawem zostanie przekazane do realizacji.";
      return View(dataToOrder);
    }

    // GET: DataToOrders/Edit/5
    public ActionResult Edit(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      DataToOrder dataToOrder = db.DataToOrders.Find(id);
      if (dataToOrder == null)
      {
        return HttpNotFound();
      }
      ViewBag.cartId = new SelectList(db.Carts, "id", "id", dataToOrder.cartId);
      return View(dataToOrder);
    }

    // POST: DataToOrders/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "id,name,surname,email,phoneNumber,street,hoseNumber,postalCode,city,country,messageToOrder,cartId")] DataToOrder dataToOrder)
    {
      if (ModelState.IsValid)
      {
        db.Entry(dataToOrder).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      ViewBag.cartId = new SelectList(db.Carts, "id", "id", dataToOrder.cartId);
      return View(dataToOrder);
    }

    // GET: DataToOrders/Delete/5
    public ActionResult Delete(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      DataToOrder dataToOrder = db.DataToOrders.Find(id);
      if (dataToOrder == null)
      {
        return HttpNotFound();
      }
      return View(dataToOrder);
    }

    // POST: DataToOrders/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
      DataToOrder dataToOrder = db.DataToOrders.Find(id);
      db.DataToOrders.Remove(dataToOrder);
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
