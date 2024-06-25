using GlobalgeoBits_Task.Data;
using GlobalgeoBits_Task.Models;
using GlobalgeoBits_Task.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace GlobalgeoBits_Task.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ApplicationDbContext _context;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        
        public async Task<IActionResult> Index([FromQuery(Name = "page")] string page, [FromQuery(Name = "size")] string size)
        {
            if (page == null || size == null || int.Parse(page) < 1)
                return Redirect("/?page=1&size=3");

            try
            {
                int int_page = int.Parse(page);
                int int_size = int.Parse(size);
                var test = (int_page - 1) * int_size;

                return View(new ProductListViewModel
                {
                    Products = await _context.Products.Skip((int_page - 1) * int_size).Take(int_size).ToListAsync(),
                    Page = int_page,
                    TotalPages = _context.Products.Count() / int_size,
                    size= int_size
                });

            }
            catch
            {
                return Redirect("/?page=1&size=3");
            }


        }

        [HttpPost("/Update")]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(UpdateListViewModel productList)
        {
            foreach (var item in productList?.Products)
            {
                var product = new Product { Id = item.Id, Price = item.Price };
                _context.Products.Attach(product);
                _context.Entry(product).Property(x => x.Price).IsModified = true;
            }
            await _context.SaveChangesAsync();
            return Redirect($"/?page={productList.page}&size=3");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
