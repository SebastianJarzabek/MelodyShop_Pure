using System;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MelodyShop.DataAccessLayer;
using MelodyShop.Models;

namespace MelodyShop.Controllers
{
  public class ProductController : Controller
  {
    private ApplicationDbContext db = new ApplicationDbContext();

    // GET: Product
    public ActionResult Index()
    {
      var products = db.Products.Include(p => p.Category);
      return View(products.ToList());
    }

    // GET: Product/Details/5
    public ActionResult Details(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Product product = db.Products.Find(id);
      if (product == null)
      {
        return HttpNotFound();
      }
      return View(product);
    }

    // GET: Product/Create
    public ActionResult Create()
    {
      ViewBag.categoryId = new SelectList(db.Categories, "id", "name");
      return View();
    }

    // POST: Product/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "id,producer,model,detail,price,categoryId")] Product product)
    {
      if (ModelState.IsValid)
      {
        db.Products.Add(product);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      ViewBag.categoryId = new SelectList(db.Categories, "id", "name", product.categoryId);
      return View(product);
    }

    // GET: Product/Edit/5
    public ActionResult Edit(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Product product = db.Products.Find(id);
      if (product == null)
      {
        return HttpNotFound();
      }
      ViewBag.categoryId = new SelectList(db.Categories, "id", "name", product.categoryId);
      return View(product);
    }

    // POST: Product/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]

    public ActionResult Edit([Bind(Include = "id,producer,model,detail,price,categoryId")] Product product)
    {
      if (ModelState.IsValid)
      {
        db.Entry(product).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      ViewBag.categoryId = new SelectList(db.Categories, "id", "name", product.categoryId);
      return View(product);
    }

    // GET: Product/Delete/5
    public ActionResult Delete(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Product product = db.Products.Find(id);
      if (product == null)
      {
        return HttpNotFound();
      }
      return View(product);
    }

    // POST: Product/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {
      Product product = db.Products.Find(id);
      db.Products.Remove(product);
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

    protected void AddToCart_Click(object sender, EventArgs e)
    {
      var cartItem = new Cart();
      db.Carts.Add(cartItem);
      db.SaveChanges();

    }
  }
}

