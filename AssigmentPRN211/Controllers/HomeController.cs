using AssigmentPRN211.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AssigmentPRN211.Controllers
{
    public class HomeController : Controller
    {
        private readonly CenimaDBContext context;
        public HomeController(CenimaDBContext _context)
        {
            context = _context;
        }

       
      

        public IActionResult Index(int id,string name_search)
        {
            
            
          
            IList<Movie> listmovie = new List<Movie>();
            if(name_search == null)
            {
                listmovie = context.Movies.Include(m => m.Genre).ToList();
            }
            else
            {
                listmovie = context.Movies.Include(m => m.Genre).
                        Where(m => m.Title.ToLower().Contains(name_search.ToLower())).ToList();
            }
            IList<Genre>genres = context.Genres.ToList();
            IList<Rate> rate = context.Rates.Where(m=>m.MovieId==id).ToList();




            //ViewBag.user = pe;
            //user=null
            ViewBag.id = id;

            
      
            ViewBag.rate = rate;
            ViewBag.listmovie = listmovie;
            ViewBag.name_search = name_search;
            ViewBag.Genres = genres;
            return View(listmovie);
        }

        public IActionResult Filter(int genre_id, string name_search)
        {
           
            IList<Movie> listmovie = new List<Movie>();

            if(name_search != null)
            {
                listmovie = context.Movies.Include(m => m.Genre).Where(m => m.Genre.GenreId == genre_id && m.Title.
                ToLower().Contains(name_search.ToLower())).ToList();
            }
            else
            {
                listmovie = context.Movies.Include(m => m.Genre).Where(m => m.Genre.GenreId == genre_id).ToList();
            }


            IList<Genre> listgenres = context.Genres.ToList();

            ViewBag.Genre = listgenres;
            ViewBag.genre_id = genre_id;
            ViewBag.listmovie = listmovie;
            ViewBag.name_search = name_search;
            return View();
        }


    }
}
