using Lab10.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace Lab10.Controllers
{
    public class Lab10Controller : Controller
    {
        private readonly Lab10Context _context;

        public Lab10Controller(Lab10Context context)
        {
            _context = context;
        }

        public IActionResult ListOfPeople()
        {
            var people = _context.Person.ToList();
            return View(people);
        }

        public IActionResult Details()
        {
            var people = _context.Person.Where(x => x.Age == 19).FirstOrDefault();
            return View(people);
        }

        public IActionResult PersonDetails()
        {
            var people = _context.Person.Where(x => x.Age == 19).FirstOrDefault();
            return View(people);
        }
    }

}
