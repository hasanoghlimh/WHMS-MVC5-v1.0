using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WHMS.Models;
using WHMS.ViewModels;


namespace WHMS.Controllers
{
    public class MoviesController : Controller
    {
        private WHMSContext _context;

        public MoviesController()
        {
            _context=new WHMSContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ViewResult Random()
        {
            var movie = new Movie() {Name = "Shrek"};

            ViewData["RandomMovie"] = movie;
            ViewBag.Movie = movie;


        

            //var customers = new List<Customer>
            //{
            //    //new Customer{Name = "Customer 1"},
            //    //new Customer{Name = "Customer 2"},
                

            //};

            var customers = _context.Customers.ToList();

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };

            //var viewResult=new ViewResult();
            //viewResult.ViewData.Model

            return View(viewModel);
            //return Content("Hello World");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1});
        }

        public ActionResult Edit(int id)
        {
            return Content("Id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));
        }
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year,int month)
        {
            return Content(year + "/" + month);
        }
    }
}