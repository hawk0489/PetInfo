using Microsoft.AspNetCore.Mvc;
using PetInfo.Helper;
using PetInfo.Models;

namespace PetInfo.Controllers
{
    public class CartController : Controller
    {
        private readonly PetDbContext _context;
        public CartController(PetDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            try
            {
                var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Pet.Price * item.Quantity);
            }
            catch (Exception)
            {

                ViewBag.total = 0;
            }
          
            return View();
        }
        private int IsExist(int Id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Pet.PetId.Equals(Id))
                {
                    return i;
                }
            }
            return -1;
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pet = await _context.Pets.FindAsync(id);
            if (pet == null)
            {
                return NotFound();
            }
            return View(pet);
        }
        public async Task<IActionResult> Buy(int Id)
        {

            //    ProductModel productModel = new ProductModel();

            var pet = _context.Pets.FirstOrDefault(m => m.PetId == Id);

            if (SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart") == null)
            {
                List<Item> cart = new List<Item>();
                cart.Add(new Item { Pet = await _context.Pets.FindAsync(Id), Quantity = 1 });
                SessionHelper.SetObjectasJson(HttpContext.Session, "cart", cart);
            }
            else
            {
                List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
                int index = IsExist(Id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new Item { Pet = await _context.Pets.FindAsync(Id), Quantity = 1 });
                }
                SessionHelper.SetObjectasJson(HttpContext.Session, "cart", cart);

            }
            return RedirectToAction("Index");
        }
        public IActionResult Remove(int Id)
        {
            List<Item> cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            int index = IsExist(Id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectasJson(HttpContext.Session, "cart", cart);
            return RedirectToAction("Index");



        }
    }
}
