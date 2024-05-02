using CIS_296_Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Linq;

namespace CharacterList.Controllers
{
    public class HomeController : Controller
    {
        private CharacterContext context { get; set; }

        public HomeController(CharacterContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var characters = context.Characters.Include(m => m.OgType).OrderBy(m => m.CharacterId).ToList();
            return View(characters);
        }
    }
}
