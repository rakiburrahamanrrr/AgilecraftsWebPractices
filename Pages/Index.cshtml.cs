using AgilecraftsWebPractices.Models;
using AgilecraftsWebPractices.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebsitePractice.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService ProductsService;
        public IEnumerable<Products> Products { get; private set; }
        
        public IndexModel(ILogger<IndexModel> logger, JsonFileProductsService productsService)
        {
            _logger = logger;
            ProductsService = productsService;
        }

        public void OnGet()
        {
            Products = ProductsService.GetProducts();
        }
    }
}
