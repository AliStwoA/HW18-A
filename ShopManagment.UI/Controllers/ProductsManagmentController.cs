using Microsoft.AspNetCore.Mvc;
using ShopManagment.UI.Models.Entities;

namespace ShopManagment.UI.Controllers
{
    public class ProductsManagmentController : Controller
    {
        public IActionResult List()
        {
            var products = new List<Product>()
{
    new Product(){Id =1, Price="599,000 تومان", Qty=12, Title="HeadPhone"},
    new Product(){Id =2, Price="14,000,000 تومان", Qty=6, Title="LapTop"},
    new Product(){Id =3, Price="12,000,000 تومان", Qty=21, Title="Mobile"},
};

            return View(products);
        }
    }
}
