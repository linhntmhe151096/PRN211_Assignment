using AssigmentPRN211.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AssigmentPRN211.Controllers
{
    public class SignUpController : Controller
    {
        private readonly CenimaDBContext context;
        public SignUpController(CenimaDBContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Register(PersonSignUp personsignup)
        {
            if (ModelState.IsValid)
            {
                var check= context.Persons.FirstOrDefault(p=>p.Email==personsignup.Email);
                if (check == null)
                {
                    Person p = new Person();
                    p.Email = personsignup.Email;
                    p.Password = personsignup.Password;
                    p.Fullname = personsignup.FullName;
                    p.Gender = personsignup.Gender;
                    p.Type = 2;
                    p.IsActive = true;
                    context.Persons.Add(p);
                    context.SaveChanges();
                    return Redirect($"/Login/Login");
                }
                else
                {
                    ViewBag.error = "Email nay da ton tai.";
                    return View();
                }
            }
            return View();
        }
    }
}
