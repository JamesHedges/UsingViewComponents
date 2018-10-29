using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;
using UsingViewComponents.Models;

namespace UsingViewComponents.Pages.Product
{
    public class CreateModel : PageModel
    {
        private readonly IProductRepository _productRepository;

        public CreateModel(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void OnGet()
        {

        }

        [BindProperty]
        public string Name { get; set; }
        [BindProperty]
        public decimal Price { get; set; }

        public IActionResult OnPost()
        {
            _productRepository.AddProduct(new Models.Product { Name = Name, Price = Price });

            return RedirectToPage("./Index");
        }
    }
}