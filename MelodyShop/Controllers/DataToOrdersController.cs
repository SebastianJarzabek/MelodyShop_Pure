using System.Collections.Generic;
using System.Data.Entity;
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
      var dataToOrders = db.DataToOrders.Include(c => c.Product);
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
      if (ModelState.IsValid)
      {
        var carts = db.Carts.Include(c => c.Product);
        var cartItems = carts.ToList();

        foreach (var item in cartItems)
        {
          dataToOrder.productId = item.productId;
          dataToOrder.quantity = item.quantity.ToString();
          dataToOrder.price = item.price.ToString();
          db.DataToOrders.Add(dataToOrder);
          db.Carts.Remove(item);
        }
        db.SaveChanges();

        TempData["SM"] = "Dziękujemy, Twoje zamówienie zostało dodane. Niebawem zostanie przekazane do realizacji.";
        return RedirectToAction("Index", "Home");
      }

      ViewBag.cartId = new SelectList(db.Carts, "id", "id", dataToOrder);
      TempData["SM"] = "Aby przekazać zamówienie do realizacji wszystkie pola muszą być uzupełnione.";
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
      ViewBag.cartId = new SelectList(db.Carts, "id", "id", dataToOrder);
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
      ViewBag.cartId = new SelectList(db.Carts, "id", "id", dataToOrder);
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
