using LogRegistration.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LogRegistration.Controllers
{
    [Authorize]
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public JsonResult GetProducts()
        {
            var products = _context.Products.ToList();
            return Json(products);

            //var receivingReceipt = _context.ReceivingReports.ToList();
            //return Json(receivingReceipt);
        }
        [HttpPost]
        #region
        //public async Task<IActionResult> Insert(TbProduct model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Products.Add(model);
        //       await _context.SaveChangesAsync();
        //        return Json("Product Details saved");
        //    }
        //    return Json("Model Validation failed");
        //}
        #endregion
        public JsonResult Insert(TbProduct model)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(model);
                _context.SaveChanges();
                return Json("Product Details saved");
            }
            return Json("Model Validation failed");
        }

        //public JsonResult Receive(ReceivingReport model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.ReceivingReports.Add(model);
        //        _context.SaveChanges();
        //        return Json("Product Details Saved");
        //    }
        //    return Json("Model Validation failed");
        //}

        [Authorize]
        public IActionResult ReceivingReceipt()
        {
            return View();
        }
    }
}
