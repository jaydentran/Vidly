using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            //var movie = new Movie() { Name = "Shred!" };
            var customers = new List<Customer>
            {
                   new Customer { Id = 1, Name = "John Smith" },
                   new Customer { Id = 2, Name = "Mary Williams" }
            };

            var viewModel = new RandomMovieViewModel
            {
                //Movie = movie,
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Details(int id)
        {
            //var movie = new Movie() { Name = "Shred!" };
            var customers = new List<Customer>
            {
                   new Customer { Id = 1, Name = "John Smith" },
                   new Customer { Id = 2, Name = "Mary Williams" }
            };

            //var viewModel = new RandomMovieViewModel
            //{
            //    //Movie = movie,
            //    Customers = customers
            //};
            if (id > customers.Count || id <= 0)
                return HttpNotFound();
            var model = customers[id - 1];
            
            return View(model);
      
            
        }
    }
}