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
                string name = p?.Name;
                decimal? price = p?.Price;
                results.Add($"Name: {name}, Price: {price}");
            }
            return View(results);
        }
    }
}