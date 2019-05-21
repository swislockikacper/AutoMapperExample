using AutoMapper;
using AutoMapperExample.DTOs;
using AutoMapperExample.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace AutoMapperExample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    ProductPrice = 1,
                    ProductName = "Product1"
                },
                new Product
                {
                    Id = 2,
                    ProductPrice = 2,
                    ProductName = "Product2"
                },
                new Product
                {
                    Id = 3,
                    ProductPrice = 3,
                    ProductName = "Product3"
                }
            };

            var productDtos = Mapper.Map<List<Product>, List<ProductDTO>>(products);

            return View(productDtos);
        }
    }
}