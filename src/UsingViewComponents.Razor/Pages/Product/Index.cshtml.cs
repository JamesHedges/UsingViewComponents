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
        private IProductRepository _productRepository;

        public IndexModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void OnGet()
        {
            Products = _productRepository.Products;
        }

        public IEnumerable<UsingViewComponents.Models.Product> Products { get; set; }
    }
}