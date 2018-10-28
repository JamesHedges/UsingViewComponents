using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UsingViewComponents.Models;

namespace UsingViewComponents.Pages.Product
{
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
            IProductRepository repo = new MemoryProductRepository();
            Products = repo.Products;
        }

        public IEnumerable<UsingViewComponents.Models.Product> Products { get; set; }
    }
}