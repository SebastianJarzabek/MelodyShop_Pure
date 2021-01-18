using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using MelodyShop.DataAccessLayer;
using MelodyShop.Models;

namespace MelodyShop.Controllers
{
  public class CartsController : Controller
  {
    private ApplicationDbContext db = new ApplicationDbContext();

    // GET: Carts
    public ActionResult Index()
    {
      var carts = db.Carts.Include(c => c.Product);
      return View(carts.ToList());
    }

    // GET: Product/AddToCart/5
    public ActionResult AddToCart(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }

      var product = db.Products.Find(id);

      var cartItem = new Cart()
      {
        productId = product.id,
        quantity = 1,
        price = 1 * product.price
      };
      db.Carts.Add(cartItem);
      db.SaveChanges();
      return RedirectToAction("Index");
    }

    // GET: Carts/Details/5
    public ActionResult Details(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Cart cart = db.Carts.Find(id);
      if (cart == null)
      {
        return HttpNotFound();
      }
      return View(cart);
    }

    // GET: Carts/Create
    public ActionResult Create()
    {
      ViewBag.productId = new SelectList(db.Products, "id", "producer");
      return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create(Product item, [Bind(Include = "id,productId,quantity,price")] Cart cart)
    {
      if (ModelState.IsValid)
      {
        cart.productId = item.id;
        cart.quantity = 1;
        cart.price = item.price;


        db.Carts.Add(cart);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      ViewBag.productId = new SelectList(db.Products, "id", "producer", cart.productId);
      return View(cart);
    }



    // POST: Carts/Create
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Create([Bind(Include = "id,productId,quantity,price")] Cart cart)
    {
      if (ModelState.IsValid)
      {
        db.Carts.Add(cart);
        db.SaveChanges();
        return RedirectToAction("Index");
      }

      ViewBag.productId = new SelectList(db.Products, "id", "producer", cart.productId);
      return View(cart);
    }

    // GET: Carts/Edit/5
    public ActionResult Edit(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Cart cart = db.Carts.Find(id);
      if (cart == null)
      {
        return HttpNotFound();
      }
      ViewBag.productId = new SelectList(db.Products, "id", "producer", cart.productId);
      return View(cart);
    }

    // POST: Carts/Edit/5
    // To protect from overposting attacks, enable the specific properties you want to bind to, for 
    // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult Edit([Bind(Include = "id,productId,quantity,price")] Cart cart)
    {
      if (ModelState.IsValid)
      {
        db.Entry(cart).State = EntityState.Modified;
        db.SaveChanges();
        return RedirectToAction("Index");
      }
      ViewBag.productId = new SelectList(db.Products, "id", "producer", cart.productId);
      return View(cart);
    }

    // GET: Carts/Delete/5
    public ActionResult Delete(int? id)
    {
      if (id == null)
      {
        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
      }
      Cart cart = db.Carts.Find(id);
      if (cart == null)
      {
        return HttpNotFound();
      }
      return View(cart);
    }

    // POST: Carts/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public ActionResult DeleteConfirmed(int id)
    {

      Cart cart = db.Carts.Find(id);
      var producer = cart.Product.producer;
      var model = cart.Product.model;

      db.Carts.Remove(cart);
      db.SaveChanges();
      TempData["SM"] = $"Usunięto produkt {producer} {model} z koszyka.";
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
