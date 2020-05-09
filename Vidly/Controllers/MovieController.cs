﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shred!" };
            var customers = new List<Customer>
            {
                   new Customer { Name = "Customer 1" },
                   new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };
            return View(viewModel);
            
        }
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                   new Movie { Name = "Toy Story 1" },
                   new Movie { Name = "Superman" }
            };
            var viewModel = new IndexMovieViewModel
            {
                Movies = movies
            };
            return View(viewModel);

        }

      
    }
}