using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestMVC.Repository;

namespace TestMVC.Controllers
{
    public class ProductController : Controller
    {
        readonly IProductRepository repository;

        //inject dependency
        public ProductController(IProductRepository repository)
        {
            this.repository = repository;
        }

        public ActionResult Index()
        {
            var data = repository.GetAll();  /// using dependency here
            var addData = repository.Add(new Product());
            var deleteData = repository.Delete(1);
            var updateData = repository.Update(new Product());
            return View(data);
        }

        //Other Code

        public Product NewSyntax
        {
            get
            {
                Product p = new Product();
                p.Id = 1;
                p.Name = "Waris";
                p.Price = 1.0m;
                return p;
            }
        }
    }
}