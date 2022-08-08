using AssigmentPRN211.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace AssigmentPRN211.Controllers
{
    public class AdminController : Controller
    {
        private readonly CenimaDBContext context;
        public AdminController(CenimaDBContext _context)
        {
            context = _context;
        }

        public IActionResult Index()
        {
            IList<Movie> listmovie = context.Movies.ToList();
            ViewBag.listmovie = listmovie;
            return View();
        }

        public IActionResult ListMovie()
        {
            IList<Movie> listmovie = context.Movies.ToList();
            ViewBag.listmovie = listmovie;

            return View();
        }

        public IActionResult AddMovie(Movie newMovie)
        {
            context.Movies.Add(newMovie);
            context.SaveChanges();
            return RedirectToAction("ListMovie");
        }

        public IActionResult DeleteMovie(int id)
        {
            var movie = context.Movies.Where(m=>m.MovieId == id).FirstOrDefault();
            if(movie != null)
            {
                context.Remove(movie);
                context.SaveChanges();
            }
            
            return RedirectToAction("ListMovie");
        }
        public IActionResult DeleteGenre(int id)
        {
            var gen = context.Genres.Where(m => m.GenreId == id).FirstOrDefault();
            if (gen != null)
            {
                context.Remove(gen);
                context.SaveChanges();
            }

            return RedirectToAction("ListGenre");
        }

        public IActionResult EditMovie(int?id)
        {
            var movie = context.Movies.Find(id);

            return RedirectToAction("ListMovie");
        }

        public IActionResult EditMovie(Movie newMovie)
        {
            var movie = context.Movies.Where(m => m.MovieId == newMovie.MovieId).FirstOrDefault();
            if(movie != null)
            {
                movie.Title = newMovie.Title;
                movie.Description = newMovie.Description;
                movie.Year = newMovie.Year;
                movie.Image = newMovie.Image;
                context.SaveChanges();
            }

            return RedirectToAction("ListMovie");
        }

        public IActionResult ListGenre()
        {
            IList<Genre> genres = context.Genres.ToList();
            ViewBag.genres = genres;

            return View();
        }
    }
}
