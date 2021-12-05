using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguagesFeatures.Contrillers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {   

          Product [] productArray = {
                new Product {Name = "Kayak", Price = 275M},
                new Product {Name = "Lifejacket", Price = 48.95M}, 
                new Product {Name = "Soccer ball", Price = 19.50M},
                new Product {Name = "Corner flag", Price = 34.95M}
            };

            decimal priceFilterTotal = productArray.Fil

            return View("Index");
              
            // ShoppingCart cart = new ShoppingCart {Products = Product.GetProducts()};
            // Product [] productArray = {
            //     new Product {Name = "Kayak", Price = 275M},
            //     new Product {Name = "Lifejacket", Price = 48.95M}
            // };
            // decimal cartTotal = cart.TotalPrices();
            // decimal arrayTotal = productArray.TotalPrices();
            // decimal filterCart = cart.FilterByPrice(20M).TotalPrices();
            // return View("Index", new string[]{$"FilterCartType: {filterCart}"});


            // ShoppingCart cart = new ShoppingCart {Products = Product.GetProducts() };
            // decimal cartTotal = cart.TotalPrices();
            // return View ("Index", cartTotal);
        //     List<string> results = new List<string>();
        //     foreach (Product p in Product.GetProducts())
        //     {
        //         string name = p?.Name ?? "<Noname>";
        //         decimal? price = p?.Price ?? 0;
        //         string relatedName = p?.Related?.Name ?? "<None>";
        //         string category = p?.Category ?? "<No category>";
                
        //         results.Add($"Name: {name}, Price: {price}, Related: {relatedName}, Category: {category}, Instock: {stock}");
        //     }
        //     return View(results);
        // }
        // Dictionary<string, Product> products = new Dictionary<string, Product>{
        //     {"Kayak", new Product {Name = "Kayak", Price = 258M}},
        //     {"LifeJacket", new Product {Name = "LifeJacket", Price = 48.95M}}
        //     };
        //     return View("Index", products.Keys);
            // Dictionary<string, Product> products = new Dictionary<string, Product>{
            // ["Kayak"] = new Product {Name = "Kayak", Price = 258M},
            // ["LifeJacket"] = new Product {Name = "LifeJacket", Price = 48.95M},
            // };
            // return View("Index", products.Keys);
        // object[] data = new object [] {275M, 29.95M, "apple", "orange", 100, 10};
        // decimal total = 0;
        // for (int i = 0; i < data.Length; i++)
        // {
        //     if(data[i] is decimal d)
        //     {total += d;}
        // }
         
        //     for (int i = 0; i < data.Length; i++){

        //         switch (data[i]){
        //           case decimal DecimalValue:
        //                 total += DecimalValue;
        //                 break;
        //             case int intValue when intValue > 50:
        //                 total += intValue;
        //                 break;
                
        //         }
        //     }
        
        // return View("Index", new string[] {$"Total: {total:C2}"});


        }
    }
}