using EcommTest.DAL.Concrete;
using EcommTest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EcommTest.Controllers
{
    public class ProductController : Controller
    {
        Context _context = new Context();
        public IActionResult Index()
        {
            var value = _context.Products.ToList();
            return View(value);
        }

        public IActionResult ProductDetail(int id)
        {
            //var AttrubtesList = _context.productDetails.Where(t => t.ProductsID == id).Include(t => t.productAttrubute).ToList();
            //var AttritesNames = AttrubtesList.DistinctBy(t => t.ProductAttrubuteID).Select(t => new ProductAttrubiteViewModel
            //{
            //    Name = t.productAttrubute.Name,
            //    ProductAttrubuteID = t.ProductAttrubuteID,
            //    Types = _context.productDetails.Where(q => q.ProductsID == id&&q.ProductAttrubuteID==t.ProductAttrubuteID).Select(z => new ProductViewModel
            //    {
            //        ProductAttrubuteID = z.ProductAttrubuteID,
            //        TypeValue = z.TypeValue,
            //    }).ToList(),

            //}).ToList();

           var attributesList = _context.productDetails
          .Where(t => t.ProductsID == id)
          .Include(t => t.productAttrubute).AsNoTracking()
          .ToList();

            var attributeNames = attributesList
                .GroupBy(t => t.ProductAttrubuteID)
                .Select(g => new ProductAttrubiteViewModel
                {
                    ProductAttrubuteID = g.Key,
                    Name = g.First().productAttrubute.Name,
                    Types = g.Select(z => new ProductViewModel
                    {
                        ProductAttrubuteID = z.ProductAttrubuteID,
                        TypeValue = z.TypeValue
                    }).ToList()
                })
                .ToList();

            return View(attributeNames);

        }
    }
}
