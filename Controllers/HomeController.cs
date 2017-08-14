using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Rest.Models;
using Microsoft.EntityFrameworkCore;

namespace Rest.Controllers
{
    public class HomeController : Controller
    {
        private RestContext _context;
 
        public HomeController(RestContext context)
        {
        _context = context;
        }
 
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet]
        [Route("reviews")]
        public IActionResult Reviews()
        {
             List<Review> AllReviews = _context.Reviews.ToList();
             ViewBag.Reviews = AllReviews;
             return View();
        }
        [HttpPost]
        [Route ("create_review")]
        public IActionResult CreateReview(Review review)
        {
            
            review.CreatedAt = DateTime.Now;
            review.UpdatedAt = DateTime.Now;
            _context.Add(review);
            _context.SaveChanges();
            return RedirectToAction("Reviews");
        }
        

    }
}
