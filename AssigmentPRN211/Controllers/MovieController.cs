using AssigmentPRN211.Logic;
using AssigmentPRN211.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace AssigmentPRN211.Controllers
{

    public class MovieController : Controller
    {
        private readonly CenimaDBContext context;
        public MovieController(CenimaDBContext _context)
        {
            context = _context;
        }

        
        public IActionResult Detail(int ?id)
        {
            
            //Person pe = JsonConvert.DeserializeObject<Person>(HttpContext.Session.GetString("User"));
            //int perid = pe.PersonId;
            if (id == null)
            {
                return NotFound();
            }
            
                //var rate = context.Rates.FirstOrDefault(r => r.MovieId == id && r.PersonId == perid);
                //ViewBag.Rateee = rate;
            

            var movie = context.Movies
                .Include(m => m.Genre)
                .FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            List<Rate> liscom = (from r in context.Rates join p in context.Persons
                          on r.PersonId equals p.PersonId where r.MovieId == id select r ).ToList();
            List<Person> person = context.Persons.ToList();
            ViewBag.Comment = liscom;
            ViewBag.person = person;
            ViewBag.movie = movie;







            return View(movie);
            
        }



        public IActionResult Comment (int? id)
        {

            Person pe = JsonConvert.DeserializeObject<Person>(HttpContext.Session.GetString("User"));
            int perid = pe.PersonId;
            if (id == null)
            {
                return NotFound();
            }

            var rate = context.Rates.FirstOrDefault(r => r.MovieId == id && r.PersonId == perid);
            ViewBag.Rateee = rate;


            var movie = context.Movies
                .Include(m => m.Genre)
                .FirstOrDefault(m => m.MovieId == id);
            if (movie == null)
            {
                return NotFound();
            }
            List<Rate> liscom = (from r in context.Rates
                                 join p in context.Persons
                on r.PersonId equals p.PersonId
                                 where r.MovieId == id
                                 select r).ToList();
            List<Person> person = context.Persons.ToList();
            ViewBag.Comment = liscom;
            ViewBag.person = person;






            return View(movie);

        }


        [HttpPost]
        public IActionResult addComment(Rate comments)
        {
            context.Rates.Add(comments);
            context.SaveChanges();
            return Redirect($"/Movie/Comment?id={comments.MovieId}");
                 
        }

        [HttpPost]
        public IActionResult updateComment(Rate newrates)
        {
            var ratee = context.Rates.Where(x => x.MovieId == newrates.MovieId && x.PersonId ==newrates.PersonId).FirstOrDefault();

            if (ratee != null)
            {
                ratee.Comment = newrates.Comment;
                ratee.NumericRating= newrates.NumericRating;
               
                
                
                context.SaveChangesAsync();
            }
            return Redirect($"/Movie/Comment?id={newrates.MovieId}");
        }
    }
}
