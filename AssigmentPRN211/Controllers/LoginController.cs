using AssigmentPRN211.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace AssigmentPRN211.Controllers
{
    public class LoginController : Controller
    {
        private readonly CenimaDBContext context;
        public LoginController(CenimaDBContext _context)
        {
            context = _context;
        }



        public IActionResult Login()
        {
            string email = HttpContext.Session.GetString("email");
            string pass = HttpContext.Session.GetString("password");

            ViewData["email"] = email;
            ViewData["pass"] = pass;
            return View();
        }

        public Person getPerson(string email, string password)
        {
            var acclogin = context.Persons.FirstOrDefault(x => x.Email == email && x.Password == password);
            return acclogin;
        }

        public IActionResult Logined(string email, string password)
        {


            //password = password == null ? "" : password;
            Person user = getPerson(email, password);



            HttpContext.Session.SetString("User", JsonConvert.SerializeObject(user));
            if (user != null)
            {
                if(user.Type == 1)
                {
                    return Redirect($"/Admin/Index");
                }
                else
                {
                    return Redirect($"/Home/Index");
                }
               
            }
            else
            {
                ViewBag.Error = "Login Failed! Please check your username and password!";
                return View("Login");  
            }                     
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Remove("User");
            HttpContext.Session.Clear();
            return Redirect("Login");
        }
    }
}
