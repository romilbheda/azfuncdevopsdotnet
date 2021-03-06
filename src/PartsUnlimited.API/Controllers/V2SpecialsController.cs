using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using PartsUnlimited.Models;

namespace PartsUnlimited.API.Controllers
{
    [Route("api/v2/specials")]
    public class V2SpecialsController : Controller
    {
        [HttpGet("{id}")]
        public IEnumerable<Product> GetSpecialsByUserId(int id)
        {
            var productsOnSpecial = new List<Product>
             {
                 new Product
                 {
                     SkuNumber = "OIL-0001",
                     Title = "Filter Set V2",
                     CategoryId = 5,
                     Price = 18.99M,
                     SalePrice = 18.99M,
                     ProductArtUrl = "https://raw.githubusercontent.com/Microsoft/PartsUnlimited/master/src/PartsUnlimitedWebsite/images/product_oil_filters.jpg",
                     ProductDetails = "{ \"Filter Type\" : \"Canister and Cartridge\", \"Thread Size\" : \"0.75-16 in.\", \"Anti-Drainback Valve\" : \"Yes\"}",
                     Description = "Ensure that your vehicle's engine has a longer life with our new filter set. Trapping more dirt to ensure old freely circulates through your engine.",
                     Inventory = 3,
                     LeadTime = 0,
                     RecommendationId = 16
                 },
                 new Product
                 {
                     SkuNumber = "OIL-0002",
                     Title = "Oil and Filter Combo V2",
                     CategoryId = 5,
                     Price = 24.49M,
                     SalePrice = 24.49M,
                     ProductArtUrl = "https://raw.githubusercontent.com/Microsoft/PartsUnlimited/master/src/PartsUnlimitedWebsite/images/product_oil_oil-filter-combo.jpg",
                     ProductDetails = "{ \"Filter Type\" : \"Canister\", \"Thread Size\" : \"0.75-16 in.\", \"Anti-Drainback Valve\" : \"Yes\", \"Size\" : \"1.1 gal.\", \"Synthetic\" : \"No\" }",
                     Description = "This Oil and Oil Filter combo is suitable for all types of passenger and light commercial vehicles. Providing affordable performance through excellent lubrication and breakdown resistance.",
                     Inventory = 5,
                     LeadTime = 0,
                     RecommendationId = 17
                 },
                 new Product
                 {
                     SkuNumber = "OIL-0003",
                     Title = "Synthetic Engine Oil V2",
                     CategoryId = 5,
                     Price = 26.49M,
                     SalePrice = 26.49M,
                     ProductArtUrl = "https://raw.githubusercontent.com/Microsoft/PartsUnlimited/master/src/PartsUnlimitedWebsite/images/product_oil_premium-oil.jpg",
                     ProductDetails = "{ \"Size\" :  \"1.1 Gal.\" , \"Synthetic\" : \"Yes\"}",
                     Description = "This Oil is designed to reduce sludge deposits and metal friction throughout your cars engine. Provides performance no matter the condition or temperature.",
                     Inventory = 11,
                     LeadTime = 0,
                     RecommendationId = 18
                 }
             };
            return productsOnSpecial;
        }
    }
}