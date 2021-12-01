using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LanguageFeatures.Models;

namespace LanguagesFeatures.Contrillers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {   
            List<string> results = new List<string>();
            foreach (Product p in Product.GetProducts())
            {
                string name = p?.Name ?? "<Noname>";
                decimal? price = p?.Price ?? 0;
                string relatedName = p?.Related?.Name ?? "<None>";
                string category = p?.Category ?? "<No category>";
                results.Add($"Name: {name}, Price: {price}, Related: {relatedName}, Category: {category}");
            }
            return View(results);
        }
    }
}